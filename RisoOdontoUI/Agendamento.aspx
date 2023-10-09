<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agendamento.aspx.cs" Inherits="RisoOdontoUI.Agendamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<link rel="stylesheet" href="resources/css/agendamento.css">

	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">

	<%--bootstrap--%>
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous">

 
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
  
		<section class="ftco-section">
	<div class="container">
	<div class="row justify-content-center">
	<div class="col-md-6 text-center mb-5">
	<h2 class="heading-section">Agendamento Riso Odonto</h2>
	</div>
	</div>
	<div class="row">
	<div class="col-md-12">
	<div class="content w-100">
	<div class="calendar-container">
	<div class="calendar">
	<div class="year-header">
	<span class="left-button fa fa-chevron-left" id="prev"> </span>
	<span class="year" id="label"></span>
	<span class="right-button fa fa-chevron-right" id="next"> </span>
	</div>
	<table class="months-table w-100">
	<tbody>
	<tr class="months-row">
	<td class="month">Jan</td>
	<td class="month">Fev</td>
	<td class="month">Mar</td>
	<td class="month">Apr</td>
	<td class="month">Mai</td>
	<td class="month">Jun</td>
	<td class="month">Jul</td>
	<td class="month">Aug</td>
	<td class="month">Set</td>
	<td class="month">Out</td>
	<td class="month">Nov</td>
	<td class="month">Dez</td>
	</tr>
	</tbody>
	</table>

 

	<table class="days-table w-100">
	<td class="day">Dom</td>
	<td class="day">Seg</td>
	<td class="day">Ter</td>
	<td class="day">Qua</td>
	<td class="day">Qui</td>
	<td class="day">Sex</td>
	<td class="day">Sab</td>
	</table>
	<div class="frame">
	<table class="dates-table w-100">
	<tbody class="tbody">
	</tbody>
	</table>
	</div>
	<button class="button" id="add-button">Agendar</button>
	</div>
	</div>
	<div class="events-container">
	</div>
	<div class="dialog" id="dialog">
	<h2 class="dialog-header"> Add New Event </h2>
	<form class="form" id="form">
	<div class="form-container" align="center">
	<label class="form-label" id="valueFromMyButton" for="name">Event name</label>
	<input class="input" type="text" id="name" maxlength="36">
	<label class="form-label" id="valueFromMyButton" for="count">Number of people to invite</label>
	<input class="input" type="number" id="count" min="0" max="1000000" maxlength="7">
	<input type="button" value="Cancel" class="button" id="cancel-button">
	<input type="button" value="OK" class="button button-white" id="ok-button">
	</div>
	</form>
	</div>
	</div>
	</div>
	</div>
	</div>
	</section>
		
    </form>


	<%--javascript--%>
	<script src="resources/js/site.js"></script>
	
	<%--bootstrap--%>
	<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-HwwvtgBNo3bZJJLYd8oVXjrBZt8cqVSpeBNS5n7C8IVInixGAoxmnlMuBnhbgrkm" crossorigin="anonymous"></script>

	<%--jquery--%>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>

	<%--popper--%>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/2.11.8/umd/popper.min.js"></script>
	
</body>
</html>
