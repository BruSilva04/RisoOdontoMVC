﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agendamento.aspx.cs" Inherits="RisoOdontoUI.Agendamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <!-- arquivos style -->
  <link href="RisoOdonto/CSS/agendamento.css" rel="stylesheet">
  <link href="RisoOdonto/CSS/darkMode.css" rel="stylesheet">

  <title>Calendario</title>
</head>
<body>
    <!-- dark mode -->
  
  <div class="toggle">
    <input id="switch" type="checkbox" name="theme">
    <label for="switch">Toggle</label>
  </div>

<!-- -------- -->
    <form id="form1" runat="server">
<div id="container">
      <div id="header">
        <div id="monthDisplay" runat="server"></div>

        <div>
          <asp:Button ID="backButton" runat="server" Text="Voltar" OnClick="backButton_Click" />
            <asp:Button ID="nextButton" runat="server" Text="Proximo" onClick="nextButton_Click" />
          <%--<button id="backButton" runat="server" onClick="">Voltar</button>--%>
          <%--<button id="nextButton">Próximo</button>--%>
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
      <h2>Agendamento</h2>

      <input id="eventTitleInput" placeholder="Nome Completo" />
      <input id="eventTitleInput" placeholder="Especialidade" />
      <input id="eventTitleInput" placeholder="Primeira Consulta?" />
      <input id="eventTitleInput" placeholder="Se não, qual o Dr.?" />

      <button id="saveButton">  Agendar</button>
      <button id="cancelButton">Cancelar</button>
  </div>

  <div id="deleteEventModal">
      <h2>Encaminhar</h2>

      <div id="eventText"></div><br>

      <button id="WhatButton"><a class="whatsapp-link" href="https://web.whatsapp.com/sen?phone=5511979682022" target="_blank">Encaminhar via zapzap</a></button>
      <button id="deleteButton">Excluir</button>
      <button id="closeButton">Fechar</button>
  </div>

  <div id="modalBackDrop"></div>
    </form>


     <script src="RisoOdonto/js/darkMode.js"></script>
  <script src="RisoOdonto/js/agendamento.js"></script>
</body>
</html>
