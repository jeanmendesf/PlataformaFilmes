USE db_PlataformaVideos

--Criando tabela de Filme
USE db_PlataformaVideos
CREATE TABLE tbl_Filme(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR(100) NOT NULL,
	Descricao VARCHAR(300))


--Criando tabela Categoria
USE db_PlataformaVideos
CREATE TABLE tbl_Categoria(
	Id INT PRIMARY KEY IDENTITY NOT NULL, 
	Nome VARCHAR(50) NOT NULL,
	Descricao VARCHAR(300))


--Criando tabela Diretor
USE db_PlataformaVideos
CREATE TABLE tbl_Diretor(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	FilmeId INT)


--Entidade associativa entre Filme e Categoria
USE db_PlataformaVideos
CREATE TABLE tbl_Filme_Categoria(
	Id INT PRIMARY KEY IDENTITY NOT NULL,
	FilmeId INT NOT NULL,
	CategoriaId INT NOT NULL)




