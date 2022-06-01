<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/teacher.Master" AutoEventWireup="true" CodeBehind="Messages.aspx.cs" Inherits="PROJE1OKULKAYIT.WebForm1" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <section class="blog_w3ls py-5" id="events">
            <div class="container py-xl-5 py-lg-3">
                <h3 class="title-w3 mb-5 text-center font-weight-bold">MESSAGES</h3>
                <div class="row mt-4">
                    <!-- blog grid -->
                    <div class="col-lg-4">
                        <div class="wthree-title mt-lg-5 pt-lg-3">
                            <h3 class="w3pvt-title text-bl">Messages Box</h3>
                            <p class="border-top pt-4 mt-4">
                                If you see some kind messages, don't forget to publish :)
                            </p>
                        </div>
                    </div>
                    <!-- //blog grid -->
                    <!-- blog grid -->
                    <%-- <div class="col-lg-4 col-md-6 mt-lg-0 mt-5">--%>

                    <asp:DataList ID="DataList1" runat="server" Height="136px">
                        <ItemTemplate>
                            <div class="card">
                                <div class="card-header m-0">
                                    <h5 class="blog-title card-title m-0">
                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("FirstName") %>'></asp:Label></h5>

                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("Lastname") %>'></asp:Label></h5>
                                </div>
                                <div class="card-body">
                                    <p>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("Mesaj") %>'></asp:Label>
                                    </p>
                                    <asp:Button ID="Button1" runat="server" Text="Respond Him/Her!" class="fa fa-long-arrow-right ml-2" OnClick="Button1_Click"></asp:Button>

                                </div>
                                <div class="card-footer blog_w3icon border-top pt-2 mt-3 d-flex justify-content-between">
                                    <small class="text-bl">
                                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("MobileNumber") %>'></asp:Label></small>
                                    <span>March 20,2019
                                    </span>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
            </div>
            </div>
        </section>
        <!-- //events -->

    </form>
</asp:Content>
