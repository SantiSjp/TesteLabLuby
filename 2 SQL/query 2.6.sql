delete from testedb.tabela_pessoa
where id not in ( 
	select id_pessoa
	from testedb.tabela_evento
    );