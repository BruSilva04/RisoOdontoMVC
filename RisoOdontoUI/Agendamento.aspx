<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agendamento.aspx.cs" Inherits="RisoOdontoUI.Agendamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	
    
    <link rel="stylesheet" href="resources/css/agendamento.css">

    <link rel="stylesheet" href="resources/css/DarkMode.css"

 
    <title>Agendamento Riso Odonto</title>
</head>

<body>
	 <form id="form1" runat="server">

  <!-- dark mode -->
  
  <div class="toggle">
    <input id="switch" type="checkbox" name="theme">
    <label for="switch">DarkMode</label>
  </div>

<!-- Calendario -->

<body>
  <div id="container">
      <div id="header">
        <div id="monthDisplay"></div>

        <div>
          <button id="backButton">Voltar</button>
          <button id="nextButton">Próximo</button>
        </div>
          
      </div>

      <div id="weekdays">
        <div>Domingo</div>
        <div>Segunda-feira</div>
        <div>Terça-feira</div>
        <div>Quarta-feira</div>
        <div>Quinta-feira</div>
        <div>Sexta-feira</div>
        <div>Sábado</div>
      </div>


      <!-- div dinamic -->
      <div id="calendar" ></div>

   
  </div>

  <div id="newEventModal">
    <h2>Agendar</h2>

    <input id="eventTitleInput" placeholder="Event Title"/>

    <button id="saveButton"> Agendar</button>
    <button id="cancelButton">Cancelar</button>
  </div>

  <div id="deleteEventModal">
    <h2>Evento</h2>

    <div id="eventText"></div><br>


    <button id="deleteButton">Deletar</button>
    <button id="closeButton">Fechar</button>
  </div>

  <div id="modalBackDrop"></div>
		
    </form>


	<%--javascript--%>
	<script src="resources/js/site.js"></script>

    <script src="resources/js/DarkMode.js"></script>
	
	
	
</body>
</html>
