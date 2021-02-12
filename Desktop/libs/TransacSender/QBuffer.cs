using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TransacSender
{
	internal class QBuffer<TEntity>
	{
		Queue<TEntity> queue;
		string file_repos_name;
		string thisName;

		public QBuffer(string reponame)
		{
			thisName = reponame;
			init();
		}

		private void init()
		{
			checkDir();

			file_repos_name = $"repos\\{thisName}.txt";

			if (File.Exists(file_repos_name))
			{
				string j = File.ReadAllText(file_repos_name, Encoding.UTF8);
				queue = JsonConvert.DeserializeObject<Queue<TEntity>>(j);
			}
			else
			{
				queue = new Queue<TEntity>();
			}
		}
		void checkDir()
		{
			if (!Directory.Exists("repos"))
				Directory.CreateDirectory("repos");
		}

		public void write()
		{
			string j = JsonConvert.SerializeObject(queue);
			File.WriteAllText(file_repos_name, j, Encoding.UTF8);
		}

		public void AddRange(IEnumerable<TEntity> items)
		{
			lock (this)
			{
				foreach (var item in items)
				{
					queue.Enqueue(item);
					write();
				}
			}
		}

		public IEnumerable<TEntity> Items
		{
			get
			{
				return queue.ToArray();
			}
		}

		public int Count
		{
			get
			{
				lock (this)
				{
					return queue.Count;
				}
			}
		}

		public bool IsEmpty
		{
			get
			{
				lock (this)
				{
					return queue.Count == 0;
				}
			}
		}

		public TEntity ReputItem()
		{
			lock (this)
			{
				var o = queue.Dequeue();
				queue.Enqueue(o);
				write();
				return o;
			}
		}
		public void RemoveFirst()
		{
			lock (this)
			{
				_ = queue.Dequeue();
				write();
			}
		}

		public TEntity PeekItem()
		{
			lock (this)
			{
				return queue.Peek();
			}
		}
		// Необходимо еще фиксировать на диске.
		public void PutItem(TEntity ent)
		{
			lock (this)
			{
				queue.Enqueue(ent);
				write();
			}
		}
	}
}
