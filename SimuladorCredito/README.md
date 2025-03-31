# SimuladorCredito
Aplicación web desarrollada en C# y ASP.NET Web Forms que permite simular pagos de cuotas 
para un crédito, ingresando el monto, la tasa de interés y el plazo en meses.
# Simulador de Crédito

## Descripción
Este proyecto es un simulador de crédito que permite a los usuarios calcular la cuota mensual
de un préstamo basándose en tres factores: monto del crédito, tasa de interés anual y el 
plazo en meses. El simulador valida que los valores ingresados estén dentro de los rangos 
permitidos para asegurar la precisión de los cálculos.

## Tecnologías utilizadas
- **ASP.NET Web Forms**: Framework utilizado para desarrollar la aplicación web.
- **C#**: Lenguaje de programación utilizado para la lógica del backend.
- **HTML/CSS**: Utilizado para la creación y el estilo de las páginas web.
- **JavaScript**: Para la interactividad en el lado del cliente.

## Funcionalidades
1. Cálculo de Crédito: Permite calcular la cuota mensual del préstamo, considerando el monto, 
la tasa de interés y el plazo.

2. Validación de Datos: Verifica que los valores ingresados estén dentro de los rangos 
permitidos (Monto entre 1,000,000 y 10,000,000; Tasa de interés entre 1% y 3%; Plazo entre 
12 y 72 meses).

3. Interfaz de Usuario: Una interfaz sencilla y amigable para realizar el cálculo y visualizar
los resultados.

## Instalación
1. Clona este repositorio a tu máquina local usando el siguiente comando:
git clone https://github.com/dine-lab/SimuladorCredito.git
2. Abre el proyecto en Visual Studio.
3. Asegúrate de tener instalado el SDK de .NET adecuado.
4. Compila y ejecuta el proyecto en Visual Studio.

## Uso
1. Al abrir la aplicación, verás campos de entrada para el monto del crédito, la tasa de 
interés y el plazo en meses.
2. Ingresa los valores de acuerdo con los rangos permitidos:
- Monto: Entre 1,000,000 y 10,000,000
- Interés: Entre 1% y 3%
- Plazo: Entre 12 y 72 meses
3. Haz clic en "Pedir Crédito" para ver el cálculo de la cuota mensual.
4. Si los valores ingresados no son válidos, el sistema mostrará un mensaje de error 
indicando los rangos correctos.

## Contribuciones
Si deseas contribuir a este proyecto, sigue estos pasos:
1. Haz un fork del repositorio.
2. Crea una rama para tu contribución.
3. Realiza los cambios y haz un pull request.

## Licencia
Este proyecto está bajo la Licencia MIT. Consulta el archivo LICENSE para más detalles.
