﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace NFU_Add_Order.NFU_Service {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SimpleServiceBinding", Namespace="http://114.35.57.190/soap/SimpleService")]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(MySoapObject2))]
    public partial class SimpleService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback gethelloworldOperationCompleted;
        
        private System.Threading.SendOrPostCallback ProcessMySoapObjectOperationCompleted;
        
        private System.Threading.SendOrPostCallback testtest1OperationCompleted;
        
        private System.Threading.SendOrPostCallback memberloginOperationCompleted;
        
        private System.Threading.SendOrPostCallback OrderSearchNotUseOperationCompleted;
        
        private System.Threading.SendOrPostCallback OrderChangeOrderInfoStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback OrderLogSaveOperationCompleted;
        
        private System.Threading.SendOrPostCallback OrderAddOrderInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback OrderSearchOrderInfoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SimpleService() {
            this.Url = global::NFU_Add_Order.Properties.Settings.Default.NFU_Add_Order_NFU_Service_SimpleService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event gethelloworldCompletedEventHandler gethelloworldCompleted;
        
        /// <remarks/>
        public event ProcessMySoapObjectCompletedEventHandler ProcessMySoapObjectCompleted;
        
        /// <remarks/>
        public event testtest1CompletedEventHandler testtest1Completed;
        
        /// <remarks/>
        public event memberloginCompletedEventHandler memberloginCompleted;
        
        /// <remarks/>
        public event OrderSearchNotUseCompletedEventHandler OrderSearchNotUseCompleted;
        
        /// <remarks/>
        public event OrderChangeOrderInfoStatusCompletedEventHandler OrderChangeOrderInfoStatusCompleted;
        
        /// <remarks/>
        public event OrderLogSaveCompletedEventHandler OrderLogSaveCompleted;
        
        /// <remarks/>
        public event OrderAddOrderInfoCompletedEventHandler OrderAddOrderInfoCompleted;
        
        /// <remarks/>
        public event OrderSearchOrderInfoCompletedEventHandler OrderSearchOrderInfoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:helloworld#gethelloworld", RequestNamespace="urn:helloworld", ResponseNamespace="urn:helloworld")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string gethelloworld(string name, string name2) {
            object[] results = this.Invoke("gethelloworld", new object[] {
                        name,
                        name2});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void gethelloworldAsync(string name, string name2) {
            this.gethelloworldAsync(name, name2, null);
        }
        
        /// <remarks/>
        public void gethelloworldAsync(string name, string name2, object userState) {
            if ((this.gethelloworldOperationCompleted == null)) {
                this.gethelloworldOperationCompleted = new System.Threading.SendOrPostCallback(this.OngethelloworldOperationCompleted);
            }
            this.InvokeAsync("gethelloworld", new object[] {
                        name,
                        name2}, this.gethelloworldOperationCompleted, userState);
        }
        
        private void OngethelloworldOperationCompleted(object arg) {
            if ((this.gethelloworldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.gethelloworldCompleted(this, new gethelloworldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://114.35.57.190/NFU_EN/pages/WebService/service.php/ProcessMySoapObject", RequestNamespace="", ResponseNamespace="")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public MySoapObject ProcessMySoapObject(MySoapObject2[] soapObjects) {
            object[] results = this.Invoke("ProcessMySoapObject", new object[] {
                        soapObjects});
            return ((MySoapObject)(results[0]));
        }
        
        /// <remarks/>
        public void ProcessMySoapObjectAsync(MySoapObject2[] soapObjects) {
            this.ProcessMySoapObjectAsync(soapObjects, null);
        }
        
        /// <remarks/>
        public void ProcessMySoapObjectAsync(MySoapObject2[] soapObjects, object userState) {
            if ((this.ProcessMySoapObjectOperationCompleted == null)) {
                this.ProcessMySoapObjectOperationCompleted = new System.Threading.SendOrPostCallback(this.OnProcessMySoapObjectOperationCompleted);
            }
            this.InvokeAsync("ProcessMySoapObject", new object[] {
                        soapObjects}, this.ProcessMySoapObjectOperationCompleted, userState);
        }
        
        private void OnProcessMySoapObjectOperationCompleted(object arg) {
            if ((this.ProcessMySoapObjectCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ProcessMySoapObjectCompleted(this, new ProcessMySoapObjectCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://114.35.57.190/NFU_EN/pages/WebService/service.php/test.test1", RequestNamespace="urn:test.test1", ResponseNamespace="urn:test.test1")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string testtest1(string gg) {
            object[] results = this.Invoke("testtest1", new object[] {
                        gg});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void testtest1Async(string gg) {
            this.testtest1Async(gg, null);
        }
        
        /// <remarks/>
        public void testtest1Async(string gg, object userState) {
            if ((this.testtest1OperationCompleted == null)) {
                this.testtest1OperationCompleted = new System.Threading.SendOrPostCallback(this.Ontesttest1OperationCompleted);
            }
            this.InvokeAsync("testtest1", new object[] {
                        gg}, this.testtest1OperationCompleted, userState);
        }
        
        private void Ontesttest1OperationCompleted(object arg) {
            if ((this.testtest1Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.testtest1Completed(this, new testtest1CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://114.35.57.190/NFU_EN/pages/WebService/service.php/member.login", RequestNamespace="urn:member.login", ResponseNamespace="urn:member.login")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string[] memberlogin(string acc, string pass) {
            object[] results = this.Invoke("memberlogin", new object[] {
                        acc,
                        pass});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void memberloginAsync(string acc, string pass) {
            this.memberloginAsync(acc, pass, null);
        }
        
        /// <remarks/>
        public void memberloginAsync(string acc, string pass, object userState) {
            if ((this.memberloginOperationCompleted == null)) {
                this.memberloginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmemberloginOperationCompleted);
            }
            this.InvokeAsync("memberlogin", new object[] {
                        acc,
                        pass}, this.memberloginOperationCompleted, userState);
        }
        
        private void OnmemberloginOperationCompleted(object arg) {
            if ((this.memberloginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.memberloginCompleted(this, new memberloginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://114.35.57.190/NFU_EN/pages/WebService/service.php/Order.SearchNotUse", RequestNamespace="urn:Order.SearchNotUse", ResponseNamespace="urn:Order.SearchNotUse")]
        [return: System.Xml.Serialization.SoapElementAttribute("Data")]
        public string OrderSearchNotUse(out bool success, out string message) {
            object[] results = this.Invoke("OrderSearchNotUse", new object[0]);
            success = ((bool)(results[1]));
            message = ((string)(results[2]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void OrderSearchNotUseAsync() {
            this.OrderSearchNotUseAsync(null);
        }
        
        /// <remarks/>
        public void OrderSearchNotUseAsync(object userState) {
            if ((this.OrderSearchNotUseOperationCompleted == null)) {
                this.OrderSearchNotUseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOrderSearchNotUseOperationCompleted);
            }
            this.InvokeAsync("OrderSearchNotUse", new object[0], this.OrderSearchNotUseOperationCompleted, userState);
        }
        
        private void OnOrderSearchNotUseOperationCompleted(object arg) {
            if ((this.OrderSearchNotUseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OrderSearchNotUseCompleted(this, new OrderSearchNotUseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://114.35.57.190/NFU_EN/pages/WebService/service.php/Order.ChangeOrderInfoSta" +
            "tus", RequestNamespace="urn:Order.ChangeOrderInfoStatus", ResponseNamespace="urn:Order.ChangeOrderInfoStatus")]
        [return: System.Xml.Serialization.SoapElementAttribute("success")]
        public bool OrderChangeOrderInfoStatus(int id, int NowEnCount, int status, int IsCheck, out string message) {
            object[] results = this.Invoke("OrderChangeOrderInfoStatus", new object[] {
                        id,
                        NowEnCount,
                        status,
                        IsCheck});
            message = ((string)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void OrderChangeOrderInfoStatusAsync(int id, int NowEnCount, int status, int IsCheck) {
            this.OrderChangeOrderInfoStatusAsync(id, NowEnCount, status, IsCheck, null);
        }
        
        /// <remarks/>
        public void OrderChangeOrderInfoStatusAsync(int id, int NowEnCount, int status, int IsCheck, object userState) {
            if ((this.OrderChangeOrderInfoStatusOperationCompleted == null)) {
                this.OrderChangeOrderInfoStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOrderChangeOrderInfoStatusOperationCompleted);
            }
            this.InvokeAsync("OrderChangeOrderInfoStatus", new object[] {
                        id,
                        NowEnCount,
                        status,
                        IsCheck}, this.OrderChangeOrderInfoStatusOperationCompleted, userState);
        }
        
        private void OnOrderChangeOrderInfoStatusOperationCompleted(object arg) {
            if ((this.OrderChangeOrderInfoStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OrderChangeOrderInfoStatusCompleted(this, new OrderChangeOrderInfoStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://114.35.57.190/NFU_EN/pages/WebService/service.php/Order.LogSave", RequestNamespace="urn:Order.LogSave", ResponseNamespace="urn:Order.LogSave")]
        [return: System.Xml.Serialization.SoapElementAttribute("success")]
        public bool OrderLogSave(int order_id, ref string message) {
            object[] results = this.Invoke("OrderLogSave", new object[] {
                        order_id,
                        message});
            message = ((string)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void OrderLogSaveAsync(int order_id, string message) {
            this.OrderLogSaveAsync(order_id, message, null);
        }
        
        /// <remarks/>
        public void OrderLogSaveAsync(int order_id, string message, object userState) {
            if ((this.OrderLogSaveOperationCompleted == null)) {
                this.OrderLogSaveOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOrderLogSaveOperationCompleted);
            }
            this.InvokeAsync("OrderLogSave", new object[] {
                        order_id,
                        message}, this.OrderLogSaveOperationCompleted, userState);
        }
        
        private void OnOrderLogSaveOperationCompleted(object arg) {
            if ((this.OrderLogSaveCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OrderLogSaveCompleted(this, new OrderLogSaveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://114.35.57.190/NFU_EN/pages/WebService/service.php/Order.AddOrderInfo", RequestNamespace="urn:Order.AddOrderInfo", ResponseNamespace="urn:Order.AddOrderInfo")]
        [return: System.Xml.Serialization.SoapElementAttribute("success")]
        public bool OrderAddOrderInfo(string nfu_acc, string nfu_pass, int startEnCount, int Subtotal, out string message) {
            object[] results = this.Invoke("OrderAddOrderInfo", new object[] {
                        nfu_acc,
                        nfu_pass,
                        startEnCount,
                        Subtotal});
            message = ((string)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void OrderAddOrderInfoAsync(string nfu_acc, string nfu_pass, int startEnCount, int Subtotal) {
            this.OrderAddOrderInfoAsync(nfu_acc, nfu_pass, startEnCount, Subtotal, null);
        }
        
        /// <remarks/>
        public void OrderAddOrderInfoAsync(string nfu_acc, string nfu_pass, int startEnCount, int Subtotal, object userState) {
            if ((this.OrderAddOrderInfoOperationCompleted == null)) {
                this.OrderAddOrderInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOrderAddOrderInfoOperationCompleted);
            }
            this.InvokeAsync("OrderAddOrderInfo", new object[] {
                        nfu_acc,
                        nfu_pass,
                        startEnCount,
                        Subtotal}, this.OrderAddOrderInfoOperationCompleted, userState);
        }
        
        private void OnOrderAddOrderInfoOperationCompleted(object arg) {
            if ((this.OrderAddOrderInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OrderAddOrderInfoCompleted(this, new OrderAddOrderInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://114.35.57.190/NFU_EN/pages/WebService/service.php/Order.SearchOrderInfo", RequestNamespace="urn:Order.SearchOrderInfo", ResponseNamespace="urn:Order.SearchOrderInfo")]
        [return: System.Xml.Serialization.SoapElementAttribute("success")]
        public bool OrderSearchOrderInfo(out string OrderInfoData, out string message) {
            object[] results = this.Invoke("OrderSearchOrderInfo", new object[0]);
            OrderInfoData = ((string)(results[1]));
            message = ((string)(results[2]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void OrderSearchOrderInfoAsync() {
            this.OrderSearchOrderInfoAsync(null);
        }
        
        /// <remarks/>
        public void OrderSearchOrderInfoAsync(object userState) {
            if ((this.OrderSearchOrderInfoOperationCompleted == null)) {
                this.OrderSearchOrderInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnOrderSearchOrderInfoOperationCompleted);
            }
            this.InvokeAsync("OrderSearchOrderInfo", new object[0], this.OrderSearchOrderInfoOperationCompleted, userState);
        }
        
        private void OnOrderSearchOrderInfoOperationCompleted(object arg) {
            if ((this.OrderSearchOrderInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.OrderSearchOrderInfoCompleted(this, new OrderSearchOrderInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://114.35.57.190/soap/SimpleService")]
    public partial class MySoapObject2 {
        
        private string author2Field;
        
        private string name2Field;
        
        private string description2Field;
        
        private string text2Field;
        
        private int voteTotal2Field;
        
        private int voteCount2Field;
        
        /// <remarks/>
        public string Author2 {
            get {
                return this.author2Field;
            }
            set {
                this.author2Field = value;
            }
        }
        
        /// <remarks/>
        public string Name2 {
            get {
                return this.name2Field;
            }
            set {
                this.name2Field = value;
            }
        }
        
        /// <remarks/>
        public string Description2 {
            get {
                return this.description2Field;
            }
            set {
                this.description2Field = value;
            }
        }
        
        /// <remarks/>
        public string Text2 {
            get {
                return this.text2Field;
            }
            set {
                this.text2Field = value;
            }
        }
        
        /// <remarks/>
        public int VoteTotal2 {
            get {
                return this.voteTotal2Field;
            }
            set {
                this.voteTotal2Field = value;
            }
        }
        
        /// <remarks/>
        public int VoteCount2 {
            get {
                return this.voteCount2Field;
            }
            set {
                this.voteCount2Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://114.35.57.190/soap/SimpleService")]
    public partial class MySoapObject {
        
        private string authorField;
        
        private string nameField;
        
        private string descriptionField;
        
        private string textField;
        
        private int voteTotalField;
        
        private int voteCountField;
        
        /// <remarks/>
        public string Author {
            get {
                return this.authorField;
            }
            set {
                this.authorField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        public int VoteTotal {
            get {
                return this.voteTotalField;
            }
            set {
                this.voteTotalField = value;
            }
        }
        
        /// <remarks/>
        public int VoteCount {
            get {
                return this.voteCountField;
            }
            set {
                this.voteCountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void gethelloworldCompletedEventHandler(object sender, gethelloworldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class gethelloworldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal gethelloworldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void ProcessMySoapObjectCompletedEventHandler(object sender, ProcessMySoapObjectCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ProcessMySoapObjectCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ProcessMySoapObjectCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public MySoapObject Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MySoapObject)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void testtest1CompletedEventHandler(object sender, testtest1CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class testtest1CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal testtest1CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void memberloginCompletedEventHandler(object sender, memberloginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class memberloginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal memberloginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void OrderSearchNotUseCompletedEventHandler(object sender, OrderSearchNotUseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OrderSearchNotUseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal OrderSearchNotUseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool success {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string message {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void OrderChangeOrderInfoStatusCompletedEventHandler(object sender, OrderChangeOrderInfoStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OrderChangeOrderInfoStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal OrderChangeOrderInfoStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string message {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void OrderLogSaveCompletedEventHandler(object sender, OrderLogSaveCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OrderLogSaveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal OrderLogSaveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string message {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void OrderAddOrderInfoCompletedEventHandler(object sender, OrderAddOrderInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OrderAddOrderInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal OrderAddOrderInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string message {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void OrderSearchOrderInfoCompletedEventHandler(object sender, OrderSearchOrderInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class OrderSearchOrderInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal OrderSearchOrderInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public string OrderInfoData {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string message {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
    }
}

#pragma warning restore 1591