<%@ Page Title="" Language="C#" MasterPageFile="~/maestraAdministrador.Master" AutoEventWireup="true" CodeBehind="agregaServicio.aspx.cs" Inherits="CapaVisualizacion.agregaServicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<script type="text/javascript" src="js/jquery.js"></script>
     <script src="js/alertifyjs/alertify.min.js"></script>
     <script src="js/modernizr-custom.js"></script>
     <link rel="stylesheet" type="text/css" href="css/stiloPopUp.css">
	<style type="text/css">
		#contenedor{
			border-left-style: solid;
			border-right-style: solid;
			border-top-style: solid;
			border-bottom-style: solid;
			width: 75%;
			height: 55%;
		}
	</style>
	
	  <!--AREA DONDE SE CREA EL CONTENIDO DEL POPUP -->
       <div id="popup" style="display: none;">
          <div class="content-popup">
              <div class="close"><a href="#" id="close"><img src="images/close.png"/></a></div>
              <div>
                 <center>
                     <h2>Agregar Servicio</h2>
                 </center>
              </div>

              <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1"></asp:GridView>
              <asp:SqlDataSource runat="server" ID="SqlDataSource1"></asp:SqlDataSource>
          </div>
      </div>
	<br>
	<br>
	<br>
    <center>

    <!--Contenedor principal -->
    <div id="contenedor">
    	        <p>
                  <a id="open" >
                    <span class="glyphicon glyphicon-plus"></span>
                        Agregar Servicio
                  </a>
                </p> 
    </div>


    </center>

      <script type="text/javascript">
        $(document).ready(function(){
          $('#open').click(function(){
                $('#popup').fadeIn('slow');
                $('.popup-overlay').fadeIn('slow');
                $('.popup-overlay').height($(window).height());
                return false;
            });
            
            $('#close').click(function(){
                $('#popup').fadeOut('slow');
                $('.popup-overlay').fadeOut('slow');
                return false;
            });
        });
    </script>
</asp:Content>
