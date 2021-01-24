INSERT INTO testedb.tabela_evento (evento, id_pessoa) VALUES ('Evento E', 
	(select id 
    from testedb.tabela_pessoa 
    where nome = 'Lisa Romero')
);
