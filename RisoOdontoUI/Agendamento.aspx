<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agendamento.aspx.cs" Inherits="RisoOdontoUI.Agendamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	
    
    <link rel="stylesheet" href="resources/css/agendamento.css">

     <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.100.2/css/materialize.min.css">
    <link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500" rel="stylesheet"> 
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">

 
    <title>Agendamento Riso Odonto</title>
</head>

<body>
	 <form id="form1" runat="server">

  <div class="mobile-header z-depth-1">

      <div class="row">
        <div class="col-2">
          <a href="#" data-activates="sidebar" class="button-collapse" style="">
            <i class="material-icons">menu</i>
          </a>
        </div>
        <div class="col">
          <h4>Agendamento</h4>
        </div>
      </div>

    </div>

    <div class="main-wrapper">

      <div class="sidebar-wrapper z-depth-2 side-nav fixed" id="sidebar">

        <div class="sidebar-title">
          <h4>Events</h4>
          <h5 id="eventDayName">Date</h5>
        </div>
        <div class="sidebar-events" id="sidebarEvents">
          <div class="empty-message">Sorry, no events to selected date</div>
        </div>

      </div>

      <div class="content-wrapper grey lighten-3">
        <div class="container">

          <div class="calendar-wrapper z-depth-2">

            <div class="header-background">
              <div class="calendar-header">

                <a class="prev-button" id="prev">
                  <i class="material-icons">keyboard_arrow_left</i>
                </a>
                <a class="next-button" id="next">
                  <i class="material-icons">keyboard_arrow_right</i>
                </a>

                <div class="row header-title">

                  <div class="header-text">
                    <h3 id="month-name">February</h3>
                    <h5 id="todayDayName">Today is Friday 7 Feb</h5>
                  </div>

                </div>
              </div>
            </div>

            <div class="calendar-content">
              <div id="calendar-table" class="calendar-cells">

                <div id="table-header">
                  <div class="row">
                    <div class="col">Seg</div>
                    <div class="col">Ter</div>
                    <div class="col">Qua</div>
                    <div class="col">Qui</div>
                    <div class="col">Sex</div>
                    <div class="col">Sab</div>
                    <div class="col">Dom</div>
                  </div>
                </div>

                <div id="table-body" class="">

                </div>

              </div>
            </div>

            <div class="calendar-footer">
              <div class="emptyForm" id="emptyForm">
                <h4 id="emptyFormTitle">No events now</h4>
                <a class="addEvent" id="changeFormButton">Add new</a>
              </div>
              <div class="addForm" id="addForm">
                <h4>Agendar</h4>

                <div class="row">
                  <div class="input-field col s6">
                    <input id="eventTitleInput" type="text" class="validate">
                    <label for="eventTitleInput">Title</label>
                  </div>
                  <div class="input-field col s6">
                    <input id="eventDescInput" type="text" class="validate">
                    <label for="eventDescInput">Description</label>
                  </div>
                </div>

                <div class="addEventButtons">
                  <a class="waves-effect waves-light btn blue lighten-2" id="addEventButton">Add</a>
                  <a class="waves-effect waves-light btn grey lighten-2" id="cancelAdd">Cancel</a>
                </div>

              </div>
            </div>

          </div>

        </div>
      </div>

    </div>
		
    </form>


	<%--javascript--%>
	<script src="resources/js/site.js"></script>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

     <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh"
            crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
           

    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.100.2/js/materialize.min.js"></script>
    <script>
      $(".button-collapse").sideNav();
    </script>
	
	
</body>
</html>
