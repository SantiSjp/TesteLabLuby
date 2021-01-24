CREATE TABLE testedb.tabela_telefone (
  id INT NOT NULL AUTO_INCREMENT,
  telefone VARCHAR(200) NULL,
  id_pessoa INT NULL,
  PRIMARY KEY (id),
  INDEX id_pessoa_idx (id_pessoa ASC) VISIBLE,
  CONSTRAINT id_pessoa
    FOREIGN KEY (id_pessoa)
    REFERENCES testedb.tabela_pessoa (id)
);