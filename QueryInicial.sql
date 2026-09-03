INSERT INTO Paises (pais, sigla, ddi, moeda) VALUES
('BRASIL', 'BR', '55', 'R$');

SELECT * FROM Paises;

select * from Estados;

select * from Paises;

insert into Estados(estado, uf, idpais)
	values('PARANA','PR',10);
insert into Estados(estado, uf, idpais)
	values('SAO PAULO','SP',10);
commit;