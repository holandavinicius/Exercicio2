CREATE TABLE tbFamilias (
    Id      INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    NomeFamilia    VARCHAR (255)
);

CREATE TABLE tbProdutos (
    CodProduto      INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    NomeProduto     VARCHAR (255)  NULL,
    IdFamilia         INT FOREIGN KEY REFERENCES tbFamilias (Id),
    Activo          BIT            DEFAULT (0) NULL,
    DataCriacao     DATE           DEFAULT (CONVERT (DATE, getdate())) NULL,
    DataAtualizacao DATE           DEFAULT (CONVERT (DATE, getdate())) NULL,
    UltimoPreco     DECIMAL (8, 2) NULL,
    Descricao       TEXT           NULL
);

INSERT INTO tbFamilias VALUES('A')
INSERT INTO tbFamilias VALUES('B')
INSERT INTO tbFamilias VALUES('C')

