﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.DBService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employees", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Employees : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsApp1.DBService.EmployeesDetails EmployeesDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsApp1.DBService.EmployeesDetails EmployeesDetails {
            get {
                return this.EmployeesDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeesDetailsField, value) != true)) {
                    this.EmployeesDetailsField = value;
                    this.RaisePropertyChanged("EmployeesDetails");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeesDetails", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class EmployeesDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DepartmentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsApp1.DBService.Departments DepartmentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WindowsFormsApp1.DBService.Employees EmployeesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JobTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SalaryField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DepartmentId {
            get {
                return this.DepartmentIdField;
            }
            set {
                if ((this.DepartmentIdField.Equals(value) != true)) {
                    this.DepartmentIdField = value;
                    this.RaisePropertyChanged("DepartmentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsApp1.DBService.Departments Departments {
            get {
                return this.DepartmentsField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentsField, value) != true)) {
                    this.DepartmentsField = value;
                    this.RaisePropertyChanged("Departments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WindowsFormsApp1.DBService.Employees Employees {
            get {
                return this.EmployeesField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeesField, value) != true)) {
                    this.EmployeesField = value;
                    this.RaisePropertyChanged("Employees");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JobTitle {
            get {
                return this.JobTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.JobTitleField, value) != true)) {
                    this.JobTitleField = value;
                    this.RaisePropertyChanged("JobTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((this.SalaryField.Equals(value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Departments", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Departments : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<WindowsFormsApp1.DBService.EmployeesDetails> EmployeesDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<WindowsFormsApp1.DBService.EmployeesDetails> EmployeesDetails {
            get {
                return this.EmployeesDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeesDetailsField, value) != true)) {
                    this.EmployeesDetailsField = value;
                    this.RaisePropertyChanged("EmployeesDetails");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DBService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetString", ReplyAction="http://tempuri.org/IService/GetStringResponse")]
        string GetString();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetString", ReplyAction="http://tempuri.org/IService/GetStringResponse")]
        System.Threading.Tasks.Task<string> GetStringAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetEmployees", ReplyAction="http://tempuri.org/IService/GetEmployeesResponse")]
        System.Collections.Generic.List<WindowsFormsApp1.DBService.Employees> GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetEmployees", ReplyAction="http://tempuri.org/IService/GetEmployeesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WindowsFormsApp1.DBService.Employees>> GetEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetEmployeeDetails", ReplyAction="http://tempuri.org/IService/GetEmployeeDetailsResponse")]
        WindowsFormsApp1.DBService.EmployeesDetails GetEmployeeDetails(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetEmployeeDetails", ReplyAction="http://tempuri.org/IService/GetEmployeeDetailsResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.DBService.EmployeesDetails> GetEmployeeDetailsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDepartments", ReplyAction="http://tempuri.org/IService/GetDepartmentsResponse")]
        System.Collections.Generic.List<WindowsFormsApp1.DBService.Departments> GetDepartments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDepartments", ReplyAction="http://tempuri.org/IService/GetDepartmentsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WindowsFormsApp1.DBService.Departments>> GetDepartmentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDepartment", ReplyAction="http://tempuri.org/IService/GetDepartmentResponse")]
        WindowsFormsApp1.DBService.Departments GetDepartment(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDepartment", ReplyAction="http://tempuri.org/IService/GetDepartmentResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.DBService.Departments> GetDepartmentAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SaveEmployee", ReplyAction="http://tempuri.org/IService/SaveEmployeeResponse")]
        int SaveEmployee(WindowsFormsApp1.DBService.Employees employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SaveEmployee", ReplyAction="http://tempuri.org/IService/SaveEmployeeResponse")]
        System.Threading.Tasks.Task<int> SaveEmployeeAsync(WindowsFormsApp1.DBService.Employees employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SaveDepartment", ReplyAction="http://tempuri.org/IService/SaveDepartmentResponse")]
        int SaveDepartment(WindowsFormsApp1.DBService.Departments department);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SaveDepartment", ReplyAction="http://tempuri.org/IService/SaveDepartmentResponse")]
        System.Threading.Tasks.Task<int> SaveDepartmentAsync(WindowsFormsApp1.DBService.Departments department);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WindowsFormsApp1.DBService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WindowsFormsApp1.DBService.IService>, WindowsFormsApp1.DBService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetString() {
            return base.Channel.GetString();
        }
        
        public System.Threading.Tasks.Task<string> GetStringAsync() {
            return base.Channel.GetStringAsync();
        }
        
        public System.Collections.Generic.List<WindowsFormsApp1.DBService.Employees> GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WindowsFormsApp1.DBService.Employees>> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
        
        public WindowsFormsApp1.DBService.EmployeesDetails GetEmployeeDetails(int id) {
            return base.Channel.GetEmployeeDetails(id);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.DBService.EmployeesDetails> GetEmployeeDetailsAsync(int id) {
            return base.Channel.GetEmployeeDetailsAsync(id);
        }
        
        public System.Collections.Generic.List<WindowsFormsApp1.DBService.Departments> GetDepartments() {
            return base.Channel.GetDepartments();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WindowsFormsApp1.DBService.Departments>> GetDepartmentsAsync() {
            return base.Channel.GetDepartmentsAsync();
        }
        
        public WindowsFormsApp1.DBService.Departments GetDepartment(int id) {
            return base.Channel.GetDepartment(id);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.DBService.Departments> GetDepartmentAsync(int id) {
            return base.Channel.GetDepartmentAsync(id);
        }
        
        public int SaveEmployee(WindowsFormsApp1.DBService.Employees employee) {
            return base.Channel.SaveEmployee(employee);
        }
        
        public System.Threading.Tasks.Task<int> SaveEmployeeAsync(WindowsFormsApp1.DBService.Employees employee) {
            return base.Channel.SaveEmployeeAsync(employee);
        }
        
        public int SaveDepartment(WindowsFormsApp1.DBService.Departments department) {
            return base.Channel.SaveDepartment(department);
        }
        
        public System.Threading.Tasks.Task<int> SaveDepartmentAsync(WindowsFormsApp1.DBService.Departments department) {
            return base.Channel.SaveDepartmentAsync(department);
        }
    }
}