SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

CREATE TABLE `produtos` (
  `id` int(11) NOT NULL,
  `descricao` varchar(100) NOT NULL,
  `categoria` varchar(30) NOT NULL,
  `valor` double NOT NULL,
  `quantidade` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `produtos` (`id`, `descricao`, `categoria`, `valor`, `quantidade`) VALUES
(1, 'Samsung Galaxy S24 256GB 5G 8RAM', 'SmartPhones', 3400, 50),
(2, 'Notebook Acer Aspire 3 Core i3 256SSD 8RAM', 'Desktops', 3000, 30),
(3, 'Mouse Logi sem fio', 'Periféricos', 80, 50),
(4, 'Mouse RedDragon 5000dpi ', 'Periféricos', 120, 80),
(6, 'Mouse Gamer XFire', 'Periféricos', 129.9, 35),
(7, 'Teclado Mecânico Titan', 'Periféricos', 289.5, 20),
(8, 'Monitor 24\" VisionTech', 'Monitores', 899, 12),
(9, 'SSD 480GB UltraSpeed', 'Armazenamento', 249.99, 40),
(10, 'HD 1TB Seagate Blue', 'Armazenamento', 320, 25),
(11, 'Caixa de Som StormBass', 'Áudio', 159.9, 18),
(12, 'Webcam Full HD CrystalCam', 'Acessórios', 119.9, 22),
(13, 'Fonte 600W PowerMax', 'Componentes', 349, 15),
(14, 'Placa-mãe H510 Prime', 'Componentes', 699.99, 10),
(15, 'Memória RAM 8GB Fury', 'Componentes', 189.9, 30),
(16, 'Headset Thunder V3', 'Áudio', 229, 14),
(17, 'Cabo HDMI 2.0 2m', 'Acessórios', 29.9, 60),
(18, 'Notebook Orion Slim', 'Informática', 3499, 5),
(19, 'Impressora JetPrint 320', 'Impressão', 499, 8),
(20, 'Hub USB 4 portas SpeedHub', 'Acessórios', 49.9, 27),
(21, 'Mousepad XL DarkWave', 'Periféricos', 59.9, 33),
(22, 'Roteador Wi-Fi 5 AirNet', 'Redes', 199, 17),
(23, 'Adaptador USB Bluetooth', 'Acessórios', 34.9, 40),
(24, 'Placa de Vídeo GTX 1650', 'Componentes', 1299, 6),
(25, 'Gabinete Gamer FireStorm', 'Componentes', 399, 12);

CREATE TABLE `vendas` (
  `id` int(11) NOT NULL,
  `data_venda` datetime NOT NULL,
  `valor_total` double NOT NULL,
  `forma_pagamento` varchar(50) NOT NULL,
  `obs` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `itens_venda` (
  `id` int(11) NOT NULL,
  `venda_id` int(11) NOT NULL,
  `produto_id` int(11) NOT NULL,
  `qtd` int(11) NOT NULL,
  `subtotal` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

ALTER TABLE `produtos`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `vendas`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `itens_venda`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_venda` (`venda_id`),
  ADD KEY `fk_produto` (`produto_id`);

ALTER TABLE `produtos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

ALTER TABLE `vendas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `itens_venda`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `itens_venda`
  ADD CONSTRAINT `fk_produto` FOREIGN KEY (`produto_id`) REFERENCES `produtos` (`id`),
  ADD CONSTRAINT `fk_venda` FOREIGN KEY (`venda_id`) REFERENCES `vendas` (`id`) ON DELETE CASCADE;

COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
