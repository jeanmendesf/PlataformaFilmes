--Criando tabela de Filme======================================================
USE db_PlataformaVideos
CREATE TABLE tbl_Filme(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	Descricao VARCHAR(300))

ALTER TABLE tbl_Filme
	ADD DiretorId INT NOT NULL
	CONSTRAINT fk_DiretorId FOREIGN KEY (DiretorId)
	REFERENCES tbl_Diretor


--Criando tabela Diretor======================================================
USE db_PlataformaVideos
CREATE TABLE tbl_Diretor(
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	Nome VARCHAR(100) NOT NULL)


--Criando tabela Categoria======================================================
USE db_PlataformaVideos
CREATE TABLE tbl_Categoria(
	Id INT PRIMARY KEY IDENTITY NOT NULL, 
	Nome VARCHAR(50) NOT NULL,
	Descricao VARCHAR(300))


--Entidade associativa entre Filme e Categoria===================================
USE db_PlataformaVideos
CREATE TABLE tbl_Filme_Categoria(
	Id INT PRIMARY KEY IDENTITY NOT NULL)

ALTER TABLE tbl_Filme_Categoria
	ADD FilmeId INT NOT NULL
	CONSTRAINT fk_Filme
	FOREIGN KEY (FilmeId)
	REFERENCES tbl_Filme(Id)
ALTER TABLE tbl_Filme_Categoria
	ADD CategoriaId INT NOT NULL
	CONSTRAINT fk_Categoria
	FOREIGN KEY (CategoriaId)
	REFERENCES tbl_Categoria(Id)

