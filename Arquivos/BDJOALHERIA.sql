--USE master;
--GO
--DROP DATABASE BDJOALHERIA;
--GO

CREATE DATABASE BDJOALHERIA;
GO

USE BDJOALHERIA;
GO

CREATE SCHEMA JOALHERIA;
GO

--SELECT * FROM JOALHERIA.VENDA WHERE DATAVENDA >= '07/04/2020 00:00:01' AND DATAVENDA <= '07/04/2020 23:59:59' ORDER BY IDVENDA;

--ALTERAR
CREATE TABLE JOALHERIA.USUARIO(
IDUSUARIO INT IDENTITY NOT NULL PRIMARY KEY,
NOME VARCHAR(50) NOT NULL,
RG VARCHAR(12) NOT NULL,
CPF VARCHAR(14) NOT NULL,
ENDERECO VARCHAR(70) NOT NULL,
TELEFONE VARCHAR(14) NULL,
TIPO BIT NOT NULL,
USUARIO VARCHAR(15) UNIQUE NOT NULL,
SENHA VARCHAR(100) NOT NULL,
PERMISSAO VARCHAR(50) NULL
);
GO

INSERT INTO JOALHERIA.USUARIO (NOME,RG,CPF,ENDERECO,TIPO,USUARIO,SENHA, PERMISSAO) VALUES ('teste','teste','teste','teste','1','admin','admin','uefcp');
GO

SELECT * FROM JOALHERIA.USUARIO;
GO

create table JOALHERIA.LOGIN(
IDLOGIN INT IDENTITY NOT NULL PRIMARY KEY,
IDCAIXA INT NOT NULL,
IDUSUARIO INT NOT NULL,
USUARIO VARCHAR(30) NOT NULL,
DATA_LOGIN DATETIME NULL,
VALOR_CAIXA DECIMAL(10, 2) NOT NULL
FOREIGN KEY (IDUSUARIO)
REFERENCES JOALHERIA.USUARIO(IDUSUARIO)
);
GO

--Contar linhas de UMA tabela
--SELECT COUNT(JOALHERIA.USUARIO.IDUSUARIO) FROM JOALHERIA.USUARIO

--ALTERADO
CREATE TABLE JOALHERIA.CAIXA(
IDCAIXA INT IDENTITY NOT NULL PRIMARY KEY,
IDENTIFICACAO_CAIXA VARCHAR(20) NULL,
DESCRICAO VARCHAR(150) NULL,
OBSERVACOES VARCHAR(150) NULL
);
GO

INSERT INTO JOALHERIA.CAIXA (IDENTIFICACAO_CAIXA, DESCRICAO, OBSERVACOES) VALUES ('CAIXA 3','','');
GO

CREATE TABLE JOALHERIA.CLIENTE(
IDCLIENTE INT IDENTITY NOT NULL PRIMARY KEY,
NOME VARCHAR(50) NOT NULL,
tipo_documento varchar(50) null,
RG VARCHAR(12) NULL,
CPF VARCHAR(14)NOT NULL,
DATA_NASCIMENTO DATE NULL,
EMAIL VARCHAR(150) NULL,
TELEFONE VARCHAR(14)  NULL,
ENDERECO VARCHAR(150)  NULL,
CIDADE VARCHAR(30) NULL,
UF VARCHAR(2) NULL,
complemento varchar(130) null,
tipo_pessoa varchar(20) null,
TIPO_CLIENTE VARCHAR(30) NULL,
data_registro datetime null
);
GO

INSERT INTO JOALHERIA.CLIENTE (NOME,RG,CPF, DATA_NASCIMENTO) VALUES('BALCAO','1','1','22/09/1999')
GO
select * from joalheria.cliente

CREATE TABLE JOALHERIA.CATEGORIA(
IDCATEGORIA INT IDENTITY NOT NULL PRIMARY KEY,
CATEGORIA VARCHAR(20) NOT NULL
);
GO

CREATE TABLE JOALHERIA.PRODUTO(
IDPRODUTO INT IDENTITY NOT NULL PRIMARY KEY,
IDCATEGORIA INT NOT NULL,
DESCRICAO VARCHAR(30) NOT NULL,
QUANTIDADE INT NOT NULL,
PRECOIMPORTADO DECIMAL(9,2) NULL,
PRECOVENDA DECIMAL(9,2) NOT NULL,
LUCRO DECIMAL(9,2)  NULL,
OBSERVACOES VARCHAR(30) NULL,
IMAGEM VARCHAR(250) NULL
FOREIGN KEY (IDCATEGORIA)
REFERENCES JOALHERIA.CATEGORIA(IDCATEGORIA)
);
GO


--ALTERADO
CREATE TABLE JOALHERIA.VENDA(
IDVENDA INT IDENTITY NOT NULL PRIMARY KEY,
IDCLIENTE INT NOT NULL,
DATAVENDA DATETIME NOT NULL,
USUARIO VARCHAR(15) NOT NULL,
PRECOTOTAL DECIMAL(9,2) NOT NULL,
FORMAPAGAMENTO VARCHAR(20) NOT NULL,
VALORPAGO DECIMAL(9,2) NOT NULL,
TROCO DECIMAL(9,2)  NULL
FOREIGN KEY(IDCLIENTE)
REFERENCES JOALHERIA.CLIENTE(IDCLIENTE)
);
GO
SELECT * FROM JOALHERIA.VENDA WHERE DATAVENDA >= '06/06/2020 00:00:00' AND DATAVENDA<= '06/06/2020 23:59:59'
--SELECT IDVENDA, NOME AS CLIENTE, DATAVENDA, USUARIO, PRECOTOTAL, FORMAPAGAMENTO, VALORPAGO, TROCO FROM JOALHERIA.CLIENTE JOIN JOALHERIA.VENDA ON JOALHERIA.CLIENTE.IDCLIENTE = JOALHERIA.VENDA.IDCLIENTE WHERE IDVENDA = '1'
--SELECT COM JOIA VENDA E ITEMPEDIDO
--select IDCLIENTE, DATAVENDA, USUARIO, IDPRODUTO, PRECOUNITARIO, QUANTIDADEPEDIDO, DESCONTO,PRECOTOTAL, FORMAPAGAMENTO, VALORPAGO, TROCO FROM JOALHERIA.VENDA JOIN JOALHERIA.ITEMPEDIDO ON JOALHERIA.VENDA.IDVENDA = JOALHERIA.ITEMPEDIDO.IDVENDA WHERE JOALHERIA.VENDA.IDVENDA = 20


CREATE TABLE JOALHERIA.ITEMPEDIDO(
IDITEMPEDIDO INT IDENTITY NOT NULL PRIMARY KEY,
IDVENDA INT NOT NULL,
IDPRODUTO INT NOT NULL,
PRECOUNITARIO DECIMAL(9,2) NOT NULL,
QUANTIDADEPEDIDO INT NOT NULL,
DESCONTO DECIMAL(8,2) NULL
FOREIGN KEY (IDVENDA)
REFERENCES JOALHERIA.VENDA(IDVENDA),
FOREIGN KEY (IDPRODUTO)
REFERENCES JOALHERIA.PRODUTO(IDPRODUTO)
);
GO

--ALTERADO
CREATE TABLE JOALHERIA.SERVICO(
IDSERVICO INT IDENTITY NOT NULL PRIMARY KEY,
DESCRICAO VARCHAR(50) NULL,
PRECO_UNITARIO DECIMAL(8,2) NOT NULL,
);
GO

--ALTERADO
CREATE TABLE JOALHERIA.ORDEMSERVICO(
IDORDEM INT IDENTITY NOT NULL PRIMARY KEY,
IDCLIENTE INT NOT NULL,
DATAATUAL DATETIME NOT NULL,
DATAENTREGA DATETIME NULL,
DESCONTO DECIMAL(8, 2) NULL,
VALOR_TOTAL DECIMAL(8,2 ) NOT NULL,
FORMA_PAGAMENTO VARCHAR(20) NOT NULL,
VALOR_PAGO DECIMAL(8,2) NULL,
TROCO DECIMAL(8,2) NULL,
IDUSUARIO INT NOT NULL
FOREIGN KEY(IDCLIENTE)
REFERENCES JOALHERIA.CLIENTE(IDCLIENTE),
FOREIGN KEY(IDUSUARIO)
REFERENCES JOALHERIA.USUARIO(IDUSUARIO)
);
GO

--select * from joalheria.item_ordemservico where idordem = 2

--select iditem, idordem, descricao, valor_servico, quantidade_pedido from joalheria.ITEM_ORDEMSERVICO join joalheria.SERVICO on JOALHERIA.ITEM_ORDEMSERVICO.IDSERVICO = JOALHERIA.SERVICO.IDSERVICO where idordem = @idordem

--SELECT IDITEM, IDORDEM, DESCRICAO, PRECO_UNITARIO, QUANTIDADE_PEDIDO FROM JOALHERIA.ITEM
SELECT IDORDEM, NOME AS CLIENTE, DATAATUAL,DATAENTREGA, DESCONTO, VALOR_TOTAL,FORMA_PAGAMENTO, VALOR_PAGO,TROCO, IDUSUARIO FROM JOALHERIA.CLIENTE JOIN JOALHERIA.ORDEMSERVICO ON JOALHERIA.CLIENTE.IDCLIENTE = JOALHERIA.ORDEMSERVICO.IDCLIENTE WHERE IDORDEM = 1
--ALTERADO
CREATE TABLE JOALHERIA.ITEM_ORDEMSERVICO(
IDITEM INT IDENTITY NOT NULL PRIMARY KEY,
IDORDEM INT NOT NULL,
IDSERVICO INT NOT NULL,
VALOR_SERVICO DECIMAL(8,2) NOT NULL,
QUANTIDADE_PEDIDO INT NOT NULL
FOREIGN KEY(IDORDEM)
REFERENCES JOALHERIA.ORDEMSERVICO(IDORDEM),
FOREIGN KEY(IDSERVICO)
REFERENCES JOALHERIA.SERVICO(IDSERVICO)
);
GO

--ALTERADO
CREATE TABLE JOALHERIA.FECHAMENTO_CAIXA(
IDLOGIN INT IDENTITY NOT NULL PRIMARY KEY,
IDUSUARIO INT NOT NULL,
USUARIO VARCHAR(15) NOT NULL,
IDCAIXA INT NOT NULL,
DATA_LOGIN DATETIME NOT NULL,
DATA_FECHAMENTO DATETIME NOT NULL,
VALOR_CAIXA DECIMAL (8,2) NULL
FOREIGN KEY(IDUSUARIO)
REFERENCES JOALHERIA.USUARIO(IDUSUARIO),
FOREIGN KEY(IDCAIXA)
REFERENCES JOALHERIA.CAIXA(IDCAIXA)
);
GO

CREATE TABLE JOALHERIA.CONTA_CORRENTE(
IDCONTA INT IDENTITY NOT NULL PRIMARY KEY,
BANCO VARCHAR(50) NOT NULL,
TIPO_CONTA VARCHAR(20) NOT NULL,
AGENCIA VARCHAR(20) NULL,
NRCONTA VARCHAR(20) NULL,
OPERACAO VARCHAR(20) NULL,
FAVORECIDO VARCHAR(100) NULL
);
GO

--SELECT PARA RELATORIO DA TABELA VENDA COM CLIENTE
--SELECT IDVENDA, NOME AS CLIENTE, DATAVENDA, USUARIO, PRECOTOTAL, FORMAPAGAMENTO,VALORPAGO,TROCO FROM JOALHERIA.VENDA JOIN JOALHERIA.CLIENTE ON JOALHERIA.VENDA.IDCLIENTE = JOALHERIA.CLIENTE.IDCLIENTE

--SELECT DA TABELA ITEMPEDIDO, VENDA E PRODUTO PARA RELATORIO DE VER ITENS DA VENDA
--SELECT IDITEMPEDIDO, DATAVENDA, DESCRICAO, PRECOUNITARIO, QUANTIDADEPEDIDO FROM JOALHERIA.VENDA JOIN JOALHERIA.ITEMPEDIDO ON JOALHERIA.VENDA.IDVENDA = JOALHERIA.ITEMPEDIDO.IDVENDA JOIN JOALHERIA.PRODUTO ON JOALHERIA.PRODUTO.IDPRODUTO = JOALHERIA.ITEMPEDIDO.IDPRODUTO;


--TRIGGER CONTROLE CAIXA ABERTO
--drop TRIGGER utrControleCaixaAberto
--CREATE TRIGGER utrControleCaixaAberto
--ON JOALHERIA.CAIXA
--FOR INSERT
--AS
--BEGIN
----A��O
--DECLARE
--@IDCAIXA INT,
--@IDUSUARIO INT,
--@DATAHORA DATETIME,
--@VALOR DECIMAL(9,2),
--@DESCRICAO VARCHAR(100);
--SELECT
--@IDCAIXA = IDCAIXA, @IDUSUARIO = IDUSUARIO, @DATAHORA = DATAHORA, @VALOR = VALOR, @DESCRICAO = DESCRICAO 
--FROM JOALHERIA.CAIXA
--INSERT INTO JOALHERIA.CAIXAABERTO(IDUSUARIO,DATAHORA,VALOR,DESCRICAO)
--VALUES(@IDUSUARIO, @DATAHORA,@VALOR,@DESCRICAO)
--END
--GO

--TRIGGER CONTROLE CAIXA FECHADO
--CREATE TRIGGER utrControleCaixaFechado
--ON JOALHERIA.CAIXAFECHAR
--FOR INSERT
--AS
--BEGIN
----A��O
--DECLARE
--@IDUSUARIO INT,
--@IDCAIXAABERTO INT,
--@DATAHORA DATETIME,
--@VALOR DECIMAL(9,2),
--@DESCRICAO VARCHAR(100);
--SELECT @IDUSUARIO = IDUSUARIO, @IDCAIXAABERTO = IDCAIXAABERTO, @DATAHORA = DATAHORA, @VALOR = VALOR, @DESCRICAO = DESCRICAO
--FROM JOALHERIA.CAIXAFECHAR
--INSERT INTO JOALHERIA.CAIXAFECHADO(IDUSUARIO,DATAHORA,VALOR,DESCRICAO)
--VALUES(@IDUSUARIO,@DATAHORA,@VALOR,@DESCRICAO)
--END
--GO

--------------------------------------------------------------------------------------------------------------

--PROCEDIMENTO ARMAZENADO
 --CREATE PROCEDURE INSERIR_CAIXA
 --@IDUSUARIO INT,
 --@DATAHORA DATETIME,
 --@VALOR DECIMAL(9,2),
 --@DESCRICAO VARCHAR(100)
 --AS
 --INSERT INTO JOALHERIA.CAIXA(IDUSUARIO, DATAHORA, VALOR, DESCRICAO)
 --VALUES (@IDUSUARIO,@DATAHORA,@VALOR,@DESCRICAO);
 --GO

 --EXEC INSERIR_CAIXA '1','16/02/2019 12:07','12.000','CAIXA ABERTO COM 1.020'

select * from JOALHERIA.CAIXA
select * from JOALHERIA.VENDA
SELECT * FROM JOALHERIA.ITEMPEDIDO
select * from joalheria.usuario