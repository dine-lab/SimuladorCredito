using System;
using System.Globalization;
using System.Web.UI;

public partial class SimuladorCredito_Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void PedirCr_Click(object sender, EventArgs e)
    {
        try
        {
            // Definir cultura estándar para parsing
            CultureInfo cultura = CultureInfo.InvariantCulture;

            // Eliminar separadores de miles y convertir los valores
            double monto = double.Parse(CantMonto.Text.Replace(".", "").Replace(",", ""), cultura);
            double interesIngresado = double.Parse(CantInteres.Text.Replace(",", "."), cultura);
            double interesMensual = interesIngresado / 100; // Convertir a decimal
            double plazo = double.Parse(CantPlazo.Text.Replace(".", "").Replace(",", ""), cultura);

            // Validar los rangos
            if (monto < 1000000 || monto > 10000000 || interesIngresado < 1 || interesIngresado > 3 || plazo < 12 || plazo > 72)
            {
                Resultado.Text = "Error: Ingrese valores dentro de los rangos permitidos:<br/>" +
                                 "- Monto: Entre 1,000,000 y 10,000,000<br/>" +
                                 "- Interés: Entre 1% y 3%<br/>" +
                                 "- Plazo: Entre 12 y 72 meses";
                return;
            }

            // Cálculo de la cuota mensual
            double cuotaMensual = (monto * interesMensual) / (1 - Math.Pow(1 + interesMensual, -plazo));

            // Mostrar el resultado formateado
            Resultado.Text = cuotaMensual.ToString("N2", cultura);
        }
        catch (FormatException)
        {
            Resultado.Text = "Error: Ingrese valores numéricos válidos en todos los campos.";
        }
    }
}

