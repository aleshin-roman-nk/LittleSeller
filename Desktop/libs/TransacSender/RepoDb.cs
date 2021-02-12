using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransacSender
{
	/*
	 * 
	 * Идея
	 * Модуль кеша
	 * Модуль репо
	 * repo.Write(cache);
	 * кеш должен иметь метод сериализации
	 * в случае хранения всего в sqlite... может быть легко отдельный файл sqlite и отдельный модуль-экземпляр ef над этим. 
	 * 
	 */

	// или не репо а кеш

	internal interface IRepoItem
	{
		int id { get; set; }
	}

	internal class RepoDb<TEntity>
		where TEntity : IRepoItem
	{
		List<TEntity> list = null;
		string file_repos_name;
		string thisName;
		int lastId;

		public RepoDb(string name)
		{
			thisName = name;
			init();
		}

		void init()
		{
			checkDir();

			file_repos_name = $"repos\\{thisName}.txt";

			if (File.Exists(file_repos_name))
			{
				string j = File.ReadAllText(file_repos_name, Encoding.UTF8);
				//list = JsonConvert.DeserializeObject<List<TEntity>>(j);
				var o = repoFileImage<TEntity>.FromJson(j);
				list = o.Items;
				lastId = o.LastId;
			}
			else
			{
				list = new List<TEntity>();
				lastId = 0;
			}
		}

		void checkDir()
		{
			if (!Directory.Exists("repos"))
				Directory.CreateDirectory("repos");
		}

		public void Write()
		{
			//checkDir();
			//string j = JsonConvert.SerializeObject(list);
			string j = (new repoFileImage<TEntity> { LastId = lastId, Items = list }).ToJSON();
			File.WriteAllText(file_repos_name, j, Encoding.UTF8);
		}

		public IEnumerable<TEntity> Items
		{
			get
			{
				return list;
			}
		}

		public void AddIfIsUnique(TEntity o)
		{
			if(o.id == 0)
			{
				o.id = ++lastId;
				list.Add(o);
			}
			//if(list.IndexOf(o) < 0)
			//	list.Add(o);
		}

		public void Remove(TEntity o)
		{
			list.Remove(o);
		}

		public void RemoveAll(Predicate<TEntity> cond)
		{
			list.RemoveAll(cond);
		}
	}

	internal class repoFileImage<TEntity>
		where TEntity : IRepoItem
	{
		public int LastId { get; set; }
		public List<TEntity> Items { get; set; }
		public string ToJSON()
		{
			return JsonConvert.SerializeObject(this);
		}
		public static repoFileImage<TEntity> FromJson(string str)
		{
			return JsonConvert.DeserializeObject<repoFileImage<TEntity>>(str);
		}
	}
}
