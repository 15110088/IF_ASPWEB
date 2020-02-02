<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NewProduct.ascx.cs" Inherits="IFsoftDemo.Client.Product.NewProduct" %>


<asp:Repeater runat="server" ID="rptProduct">

 <HeaderTemplate>
     <div class="container">
 <div class="content">	
 <div class="row">
 	<div class="col-md-12 text-center">
 		<h2>Featured Products</h2>
 	</div>	
 </div>	
<div class="row">
    	<!----start-model-box---->
						<a data-toggle="modal" data-target=".bs-example-modal-md" href="#"> </a>
						<div class="modal fade bs-example-modal-md light-box" tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true">
						  <div class="modal-dialog modal-md">
						    <div class="modal-content light-box-info">
						    <button type="button" class="close" data-dismiss="modal" aria-hidden="true"><img src="../../Assets/images/close.png" title="close" /></button>
                             					     <h3>Place Yours content here</h3>
						     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris egestas orci et blandit dictum. Interdum et malesuada fames ac ante ipsum primis in faucibus. Interdum et malesuada fames ac ante ipsum primis in faucibus. Quisque posuere diam et est hendrerit, eget sodales lectus tincidunt. Etiam suscipit orci sapien, at molestie lorem imperdiet vitae. Fusce nunc eros, congue non hendrerit sed, lobortis scelerisque magna. Ut in nunc sem. Integer bibendum enim et erat molestie, sed interdum nisl ultricies. In hac habitasse platea dictumst. Nullam sem diam, tincidunt dapibus tellus pulvinar, pulvinar tempus dui. Integer eu faucibus arcu. Duis adipiscing commodo ipsum dapibus elementum.</p>
						    </div>
						  </div>
						</div>
						<!----start-model-box---->
 </HeaderTemplate>
    <ItemTemplate>

    
				<div class="col-md-2">
					<div class="grid">
						<div class="portfolio app mix_all" data-cat="app" style="display: inline-block; opacity: 1;">
							<div class="portfolio-wrapper">		
								<a data-toggle="modal" data-target=".bs-example-modal-md" href="#" class="b-link-stripe b-animate-go  thickbox">
							     <img src='../../Assets/images/<%#:Eval("vImage")%>' /><div class="b-wrapper"><h2 class="b-animate b-from-left    b-delay03 "><img src="../../Assets/images/link-ico.png" alt=""/></h2>
							  	</div></a>
			                </div>
					    </div>		
						<p class="text-center"><%#:Eval("vName") %></p>
						<h2 class="text-center"><%#:string.Format("{0:N0}",Eval("vPrice")) %></h2>
						<p class="text-center"><a href="details.html">Buy</a></p>
                    </div>
				</div>
				
			
				
		


    </ItemTemplate>
    <FooterTemplate>
        </div>
<div class="clearfix"></div>
</div>
    </FooterTemplate>
 </asp:Repeater>

