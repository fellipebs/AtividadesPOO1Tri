create database bdOrdemServico;
use bdOrdemServico;

CREATE TABLE OrdemServico(
  id INT AUTO_INCREMENT,
  descricao VARCHAR(60) NOT NULL,
  departamento VARCHAR(30) NOT NULL,   
  nomeUsuario VARCHAR(30) NOT NULL, 
  dataChamado DATETIME NOT NULL,
  tecnicoResponsavel VARCHAR(40) NOT NULL,
  situacaoOrdem VARCHAR(20) NOT NULL,
  PRIMARY KEY (id)
);

INSERT INTO OrdemServico VALUES(NULL, 'Teclado com defeito', 'RH', 'José', '2015/11/23', 'Juliano', 'Em andamento');
INSERT INTO OrdemServico VALUES(NULL, 'Mal contato no cabo do monitor', 'Secretaria', 'Celmi', '2017/05/12', 'Rodrigão', 'Encerrada');
INSERT INTO OrdemServico VALUES(NULL, 'Mouse não funciona', 'Supervisão', 'Cristiane', '2018/06/05', 'Juliano', 'Aguardando Material');
INSERT INTO OrdemServico VALUES(NULL, 'Teclado com defeito', 'RH', 'Geraldo', '2017/03/25', 'Juliano', 'Cancelada');