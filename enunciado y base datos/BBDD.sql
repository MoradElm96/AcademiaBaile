Create database 2dam;
USE 2dam;
GRANT ALL PRIVILEGES ON 2dam.* TO 'user';


CREATE TABLE `Clientes` (
  `idCliente` int(11) NOT NULL,
  `nombreCliente` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `saldo` decimal(8,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `Clientes`
--

INSERT INTO `Clientes` (`idCliente`, `nombreCliente`, `saldo`) VALUES
(1, 'Juan Gomez Perez', '120.00'),
(2, 'Federico Mocca', '20.00'),
(3, 'Pablo Marmol', '1200.00'),
(4, 'Jose Mota', '200.00'),
(5, 'Pablo Esquilo', '10.00'),
(6, 'Jose Ramon Rojas', '200.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Cursos`
--

CREATE TABLE `Cursos` (
  `idCurso` int(11) NOT NULL,
  `nombreCurso` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `nombreProfesor` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `tipoBaile` varchar(20) COLLATE utf8_spanish_ci NOT NULL,
  `costeMinuto` decimal(8,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `Cursos`
--

INSERT INTO `Cursos` (`idCurso`, `nombreCurso`, `nombreProfesor`, `tipoBaile`, `costeMinuto`) VALUES
(1, 'Salsa nivel 1', 'Pacho Maturana', 'Salsa', '10.00'),
(2, 'Salsa nivel 2', 'Pacho Maturana', 'Salsa', '12.00'),
(3, 'Salsa nivel 3', 'Pacho Maturana', 'Salsa', '14.00'),
(4, 'Salsa nivel 4', 'Pacho Maturana', 'Salsa', '15.00'),
(5, 'Salsa nivel 5', 'Pacho Maturana', 'Salsa', '18.00'),
(6, 'Merengue nivel 1', 'Alain Jota', 'Merengue', '10.00'),
(7, 'Merengue nivel 2', 'Alain Jota', 'Merengue', '12.00'),
(8, 'Merengue nivel 3', 'Alain Jota', 'Merengue', '13.00'),
(9, 'Merengue nivel 4', 'Alain Jota', 'Merengue', '14.00'),
(10, 'Merengue nivel 5', 'Alain Jota', 'Merengue', '15.00'),
(11, 'Merengue nivel 6', 'Alain Jota', 'Merengue', '16.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Inscripciones`
--

CREATE TABLE `Inscripciones` (
  `idCurso` int(11) NOT NULL,
  `idCliente` int(11) NOT NULL,
  `fechaAlta` date NOT NULL,
  `descuentoPorMinuto` int(2) NOT NULL,
  `minutosCurso` int(11) NOT NULL DEFAULT '10',
  `estado` varchar(10) COLLATE utf8_spanish_ci NOT NULL DEFAULT 'Abierta'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `Inscripciones`
--

INSERT INTO `Inscripciones` (`idCurso`, `idCliente`, `fechaAlta`, `descuentoPorMinuto`, `minutosCurso`, `estado`) VALUES
(1, 1, '2021-06-19', 10, 10, 'Abierta'),
(1, 2, '2021-06-19', 15, 10, 'Abierta'),
(1, 3, '2021-06-19', 10, 10, 'Abierta'),
(1, 4, '2021-06-19', 10, 10, 'Abierta'),
(1, 5, '2021-06-19', 10, 10, 'Abierta'),
(1, 6, '2021-06-19', 10, 10, 'Abierta'),
(6, 1, '2021-06-19', 10, 10, 'Abierta'),
(6, 2, '2021-06-19', 10, 10, 'Abierta'),
(6, 3, '2021-06-19', 10, 10, 'Abierta');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `Clientes`
--
ALTER TABLE `Clientes`
  ADD PRIMARY KEY (`idCliente`);

--
-- Indices de la tabla `Cursos`
--
ALTER TABLE `Cursos`
  ADD PRIMARY KEY (`idCurso`);

--
-- Indices de la tabla `Inscripciones`
--
ALTER TABLE `Inscripciones`
  ADD PRIMARY KEY (`idCurso`,`idCliente`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `Clientes`
--
ALTER TABLE `Clientes`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `Cursos`
--
ALTER TABLE `Cursos`
  MODIFY `idCurso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;