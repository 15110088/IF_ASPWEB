<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ClientControl.ascx.cs" Inherits="IFsoftDemo.Client.ClientControl" %>
<%@ Register Src="~/Client/Theme/Header.ascx" TagName="hd" TagPrefix="hd1" %>
<%@ Register Src="~/Client/Theme/Footer.ascx" TagName="ft" TagPrefix="ft1" %>
<%@ Register Src="~/Client/Theme/Container.ascx" TagName="container" TagPrefix="container" %>
<%@ Register Src="~/Client/Product/NewProduct.ascx" TagName="product" TagPrefix="product" %>
<!DOCTYPE HTML>
<html>
	<head>
		<title>The Yolk Website Template :: w3layouts</title>
		<link href="../Assets/css/bootstrap.css" rel='stylesheet' type='text/css' />
		<link href="../Assets/css/bootstrap.css" rel='stylesheet' type='text/css' />
		<link href="../Assets/css/theme.css" rel='stylesheet' type='text/css' />
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
		</script>
		<!----webfonts---->
		<link href='http://fonts.googleapis.com/css?family=Open+Sans:400,600,700,800,300' rel='stylesheet' type='text/css'>
		<!----//webfonts---->
		<script type="text/javascript" src="../Assets/js/jquery.min.js"></script>
		<script type="text/javascript" src="../Assets/js/bootstrap.js"></script>
		<script type="text/javascript" src="../Assets/js/bootstrap.min.js"></script>
		<!--  jquery plguin -->
	<!--start slider -->
	    <link rel="stylesheet" href="../Assets/css/fwslider.css" media="all">
		<script src="../Assets/js/jquery-ui.min.js"></script>
		<script src="../Assets/js/css3-mediaqueries.js"></script>
		<script src="../Assets/js/fwslider.js"></script>
	<!--end slider -->
	</head>
	<body>
        <hd1:hd runat="server" id="hd"></hd1:hd>
         <container:container runat="server" id="cn" />
         <product:product runat="server" id="product" />
         <ft1:ft runat="server" id="ft"></ft1:ft>
	</body>


 </html>















 