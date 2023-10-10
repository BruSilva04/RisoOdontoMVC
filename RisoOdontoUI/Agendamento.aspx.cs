using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RisoOdontoUI
{
    public partial class Agendamento : System.Web.UI.Page
    {
        private Hashtable ListaFeriados;



        private Hashtable GetFeriado()

        {

            Hashtable feriado = new Hashtable();

            feriado["01/01/2011"] = "Ano Novo";

            feriado["08/03/2011"] = "Carnaval";

            feriado["21/04/2011"] = "Tiradentes";

            feriado["22/04/2011"] = "Sexta-feira da Paixão";

            feriado["01/05/2011"] = "Dia do Trabalho";

            feriado["23/06/2011"] = "Corpus Christi";

            feriado["07/09/2011"] = "Independência do Brasil";

            feriado["12/10/2011"] = "Nossa Senhora Aparecida";

            feriado["02/11/2011"] = "Finados";

            feriado["15/11/2011"] = "Proclamação da República";

            feriado["25/12/2011"] = "Natal";

            return feriado;

        }



        protected void Page_Load(object sender, EventArgs e)

        {

            ListaFeriados = GetFeriado();

            Calendario.Caption = "Calendário - 2011 ";

            Calendario.FirstDayOfWeek = FirstDayOfWeek.Sunday;

            Calendario.NextPrevFormat = NextPrevFormat.FullMonth;

            Calendario.TitleFormat = TitleFormat.MonthYear;

            Calendario.ShowGridLines = true;

            Calendario.DayStyle.Height = new Unit(50);

            Calendario.DayStyle.Width = new Unit(50);

            Calendario.DayStyle.HorizontalAlign = HorizontalAlign.Center;

            Calendario.DayStyle.VerticalAlign = VerticalAlign.Middle;

            Calendario.OtherMonthDayStyle.BackColor = System.Drawing.Color.AliceBlue;

        }



        protected void Calendario_DayRender(object sender, DayRenderEventArgs e)

        {

            if (ListaFeriados[e.Day.Date.ToShortDateString()] != null)

            {

                Literal literal1 = new Literal();

                literal1.Text = "<br/>";

                e.Cell.Controls.Add(literal1);

                Label label1 = new Label();

                label1.Text = (string)ListaFeriados[e.Day.Date.ToShortDateString()];

                label1.Font.Name = "Trebuchet MS";

                label1.Font.Size = new FontUnit(FontSize.Medium);

                label1.ForeColor = System.Drawing.Color.DarkOrange;

                label1.Font.Bold = true;

                e.Cell.Controls.Add(label1);

            }

        }

        protected void Calendario_SelectionChanged(object sender, EventArgs e)

        {

            lblMsg.Text = "Data alterada para : " + Calendario.SelectedDate.ToShortDateString();



        }

        protected void Calendario_VisibleMonthChanged(object sender, MonthChangedEventArgs e)

        {

            lblMsg.Text = "Mês alterado para : " + e.NewDate.ToShortDateString();

        }

    }

}