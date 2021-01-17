<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TopicSelection.aspx.cs" Inherits="WebApp.TopicSelection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Noslēguma darbu tēmas rezervēšana</h1>
        <asp:MultiView ID="mvTopicSelection" runat="server" ActiveViewIndex="0">
            <asp:View ID="vwTopicSelection" runat="server">
                <h2>1. solis - studiju līmeņa un tēmas izvēle</h2>
                <asp:Label ID="lblQualifLevel" runat="server" Text="Studiju līmenis:" AssociatedControlID="ddlQualifLevel"></asp:Label><asp:DropDownList ID="ddlQualifLevel" runat="server" AutoPostBack="True" DataSourceID="QualifLevel" DataTextField="LevelDescription" DataValueField="LevelId"></asp:DropDownList>
                <asp:ObjectDataSource ID="QualifLevel" runat="server" SelectMethod="GetData" TypeName="DataModel.QualifLevel"></asp:ObjectDataSource>
                <asp:GridView ID="gvTopicSelection" runat="server" AutoGenerateColumns="False" BackColor="Silver" CssClass="table" DataKeyNames="TopicID" DataSourceID="TopicSelectionDataSource" OnSelectedIndexChanged="gvTopicSelection_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="Supervisor" HeaderText="Vadītājs" ReadOnly="True" SortExpression="Supervisor" />
                        <asp:BoundField DataField="Topic" HeaderText="Tēma" SortExpression="Topic" />
                        <asp:BoundField DataField="SelectionCnt" HeaderText="Rezervāciju skaits" ReadOnly="True" SortExpression="SelectionCnt" />
                        <asp:CommandField ButtonType="Button" SelectText="Izvēlēties" ShowSelectButton="True">
                        <ControlStyle CssClass="btn btn-xs" />
                        </asp:CommandField>
                    </Columns>
                    <EmptyDataTemplate>
                        <spam class="alert-warning">Izvēlētajam studiju līmenim netiek piedāvāta neviena tēma.</spam>
                    </EmptyDataTemplate>
                </asp:GridView>
                <asp:ObjectDataSource ID="TopicSelectionDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataModel.DataModelDataSetTableAdapters.TopicSelectionTableAdapter">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="ddlQualifLevel" DefaultValue="0" Name="QualifLevel" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </asp:View>
            <asp:View ID="vwStudentData" runat="server">
                 <h2>2. solis - studiju līmeņa un tēmas izvēle</h2>
                <asp:Label ID="lblTopic" runat="server" ></asp:Label>&nbsp;&nbsp;<asp:Label ID="lblSupervisor" runat="server" ></asp:Label>
                <asp:Label ID="lblStudentName" runat="server" Text="Vārds:" AssociatedControlID="txtStudentName" CssClass="sr-only"></asp:Label>
                <asp:TextBox ID="txtStudentName" runat="server" CssClass="form-control" placeholder="Vārds"></asp:TextBox><asp:RequiredFieldValidator ID="valStudentName" runat="server" ErrorMessage="Vārds jānorāda obligāti." ControlToValidate="txtStudentName"></asp:RequiredFieldValidator>
                <asp:Label ID="lblStudentSurname" runat="server" Text="Uzvārds:" AssociatedControlID="txtStudentSurname" CssClass="sr-only"></asp:Label>
                <asp:TextBox ID="txtStudentSurname" runat="server" CssClass="form-control" placeholder="Uzvārds"></asp:TextBox><asp:RequiredFieldValidator ID="valStudentSurname" runat="server" ErrorMessage="Uzvārds jānorāda obligāti." ControlToValidate="txtStudentSurname"></asp:RequiredFieldValidator>
                <asp:Label ID="lblStudentID" runat="server" Text="Apliecības numurs:" AssociatedControlID="txtStudentSurname" CssClass="sr-only"></asp:Label>
                <asp:TextBox ID="txtStudentID" runat="server" CssClass="form-control" placeholder="Apliecības numurs"/><asp:RegularExpressionValidator runat="server" ErrorMessage="Apliecības numurs sastāv no 3 pirmajiem cipariem, 3 burtiem un 3 cipariem" ControlToValidate="txtStudentID" ID="valStudentID" ValidationExpression="^[0-9]{3}[a-zA-Z]{3}[0-9]{3}$" />
            </asp:View>
        </asp:MultiView>    
            <asp:Button runat="server" Text="Atpakaļ" ID="btnBack" CausesValidation="False" CssClass="btn" OnClick="btnBack_Click" />
            &nbsp;<asp:Button runat="server" Text="Turpināt" ID="btnNext" CssClass="btn" OnClick="btnNext_Click" />
            &nbsp;<asp:Button runat="server" Text="Rezervēt" ID="btnReserve" CssClass="btn btn-primary" OnClick="btnReserve_Click" />
    <div class="well">
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </div>
</asp:Content>
