<%@ Page Title="" Language="C#" MasterPageFile="~/maestraAdministrador.Master" AutoEventWireup="true" CodeBehind="agregaServicio.aspx.cs" Inherits="CapaVisualizacion.agregaServicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <form id="form1" runat="server">
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
		#divGridPopUp{
                background-color: red;

		}
        #cont{
        	background-color: red;
        }
	</style>
	
	  <!--AREA DONDE SE CREA EL CONTENIDO DEL POPUP -->
       <div id="popup" style="display: none;" >
          <div class="content-popup" >
              <div class="close"><a href="#" id="close"><img src="images/close.png"/></a></div>
                      <div>
                         <center>
                             <h2>Agregar Servicio</h2>
                         </center>
                        
                         <table border="1">
                         	<tr>
                         		<td></td>
                         		<td></td>
                         		<td></td>
                         		<td></td>
                         	</tr>
                         </table>
                              <asp:TextBox ID="nombreDelServicio" runat="server" CssClass="form-control" placeholder="Nombre del servicio" ></asp:TextBox>   

                          <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" DataSourceID="SqlDataSource1" DataTextField="P_CARGO" DataValueField="P_CARGO"></asp:DropDownList>

                          <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' ProviderName='<%$ ConnectionStrings:ConnectionString.ProviderName %>' SelectCommand='SELECT "P_CARGO" FROM "PERFIL"'></asp:SqlDataSource>

                          <asp:TextBox ID="valorDelServicio" runat="server" CssClass="form-control" placeholder="Valor del servicio" ></asp:TextBox>   
                          <table border="0">
                              <tr>
                                  <td>Inicio:</td>
                                  <td width="30%"><input type="time" name="horaInicio" class="form-control"/></td>
                                  <td><span class="glyphicon">&#xe141;</span></td>
                                  <td>Fin:</td>
                                  <td width="30%"><input type="time" name="horaFin" class="form-control" /></td>
                                  <td><span class="glyphicon">&#xe141;</span></td>
                              </tr>
                          </table>       
                          <center>
                              <asp:Button ID="Button1" runat="server" Text="Agregar" CssClass="btn btn-danger" ValidationGroup="btn"/>
                          </center>                  
                      </div>
                </div>
                </div>
	<br>
	<br>
	<br>
    <center>

    <!--Contenedor principal -->
    <div id="contenedor" >
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
    </form>
</asp:Content>
