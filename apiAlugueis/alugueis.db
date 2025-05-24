CREATE SCHEMA alugueis;

USE alugueis;


CREATE TABLE imovel(
id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
endereco LONGTEXT NOT NULL,
valor DECIMAL(10, 2),
metragem FLOAT NOT NULL
);

CREATE TABLE people (
id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
id_imovel INT,
nome VARCHAR(255) NOT NULL,
sobrenome VARCHAR(255) NOT NULL,
cpf VARCHAR(11) NOT NULL,
FOREIGN KEY (id_imovel) REFERENCES imovel(id)
);



INSERT INTO imovel (endereco, valor, metragem) VALUES
('Rua das Flores, 123 - Centro', 1200.00, 80.5),
('Avenida Brasil, 456 - Bairro Novo', 1500.00, 95.0),
('Rua João da Silva, 789 - Vila Rica', 900.00, 60.0),
('Travessa das Palmeiras, 101 - Zona Sul', 1800.00, 120.0),
('Rua das Acácias, 202 - Zona Norte', 1100.00, 75.5),
('Rua Projetada, 303 - Leste', 1400.00, 90.0),
('Avenida das Américas, 404 - Centro', 2000.00, 130.0),
('Rua 7 de Setembro, 505 - Bairro Antigo', 800.00, 55.0),
('Rua Independência, 606 - Subúrbio', 950.00, 70.0),
('Rua Dom Pedro, 707 - Histórico', 1600.00, 100.0),
('Rua das Laranjeiras, 808 - Jardim Alegre', 1300.00, 82.0),
('Rua Nova Esperança, 909 - Vista Linda', 1000.00, 70.5),
('Alameda dos Sonhos, 1001 - Parque das Árvores', 1150.00, 76.0),
('Rua Sol Nascente, 1112 - Morada do Sol', 1700.00, 110.0),
('Avenida dos Pioneiros, 1213 - Jardim América', 1450.00, 88.5),
('Rua Bela Vista, 1314 - Altos do Morro', 1600.00, 98.0),
('Travessa São Jorge, 1415 - Bairro São Lucas', 950.00, 68.0),
('Rua do Campo, 1516 - Zona Rural', 800.00, 60.0),
('Rua Horizonte Azul, 1617 - Vila Serena', 1250.00, 79.5),
('Rua do Comércio, 1718 - Centro Antigo', 1550.00, 92.0);


INSERT INTO people (id_imovel, nome, sobrenome, cpf) VALUES
(1, 'Carlos', 'Silva', '12345678901'),
(2, 'Ana', 'Souza', '23456789012'),
(3, 'Pedro', 'Oliveira', '34567890123'),
(4, 'Mariana', 'Costa', '45678901234'),
(5, 'João', 'Pereira', '56789012345'),
(6, 'Julia', 'Almeida', '67890123456'),
(7, 'Lucas', 'Ferreira', '78901234567'),
(8, 'Beatriz', 'Lima', '89012345678'),
(9, 'Ricardo', 'Gomes', '90123456789'),
(10, 'Camila', 'Barros', '01234567890');