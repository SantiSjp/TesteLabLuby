select tp.nome pessoa, te.evento evento_pessoa
from testedb.tabela_evento as te
left outer join testedb.tabela_pessoa tp on ( tp.id = te.id_pessoa)
where te.id_pessoa is not null
order by tp.nome;
