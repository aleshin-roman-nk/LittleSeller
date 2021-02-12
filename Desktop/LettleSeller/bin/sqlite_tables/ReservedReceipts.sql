CREATE TABLE ReservedReceipts (
    id        INTEGER PRIMARY KEY AUTOINCREMENT
                      UNIQUE,
    receiptid INTEGER,
    given     BOOLEAN
);