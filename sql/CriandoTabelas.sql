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
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	FilmeId INT NOT NULL,
	CategoriaId INT NOT NULL)




