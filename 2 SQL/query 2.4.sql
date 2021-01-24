update testedb.tabela_evento set id_pessoa = (select id 
from testedb.tabela_pessoa where nome = 'John Doe') 
where evento = 'Evento D';