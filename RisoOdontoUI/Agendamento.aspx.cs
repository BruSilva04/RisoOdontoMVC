using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RisoOdontoUI
{
    public partial class Agendamento : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Inicialize a data atual para o mês atual
                DateTime currentDate = DateTime.Today;
                Session["CurrentDate"] = currentDate;

                // Atualize a exibição do mês
                Form.InnerText = currentDate.ToString("MMMM yyyy");
            }
        }
        protected void backButton_Click(object sender, EventArgs e)
        {
            // Obtém a data atual da sessão
            DateTime currentDate = (DateTime)Session["CurrentDate"];

            // Calcula o mês anterior
            currentDate = currentDate.AddMonths(-1);

            // Atualiza a data na sessão
            Session["CurrentDate"] = currentDate;

            // Atualiza a exibição do mês
            Form.InnerText = currentDate.ToString("MMMM yyyy");
        }

        protected void nextButton_Click(object sender, EventArgs e)
        {
            // Obtém a data atual da sessão
            DateTime currentDate = (DateTime)Session["CurrentDate"];

            // Calcula o próximo mês
            currentDate = currentDate.AddMonths(1);

            // Atualiza a data na sessão
            Session["CurrentDate"] = currentDate;

            // Atualiza a exibição do mês
            monthDisplay.InnerText = currentDate.ToString("MMMM yyyy");
        }

        private void UpdateMonthDisplay()
        {
            // Obtém a data atual da sessão
            DateTime currentDate = (DateTime)Session["CurrentDate"];

            // Calcula o próximo mês
            currentDate = currentDate.AddMonths(1);

            // Atualiza a data na sessão
            Session[

        "CurrentDate"] = currentDate;

            // Atualiza a exibição do mês
            monthDisplay.InnerText = currentDate.ToString(
            monthDisplay.InnerText =
        "MMMM yyyy");
        }
    }
}