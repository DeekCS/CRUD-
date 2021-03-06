#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="College")]
	public partial class collegeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertadmin(admin instance);
    partial void Updateadmin(admin instance);
    partial void Deleteadmin(admin instance);
    partial void InsertCourse(Course instance);
    partial void UpdateCourse(Course instance);
    partial void DeleteCourse(Course instance);
    partial void Insertscore(score instance);
    partial void Updatescore(score instance);
    partial void Deletescore(score instance);
    partial void Insertstudent(student instance);
    partial void Updatestudent(student instance);
    partial void Deletestudent(student instance);
    #endregion
		
		public collegeDataContext() : 
				base(global::FinalProject.Properties.Settings.Default.CollegeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public collegeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public collegeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public collegeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public collegeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<admin> admins
		{
			get
			{
				return this.GetTable<admin>();
			}
		}
		
		public System.Data.Linq.Table<Course> Courses
		{
			get
			{
				return this.GetTable<Course>();
			}
		}
		
		public System.Data.Linq.Table<score> scores
		{
			get
			{
				return this.GetTable<score>();
			}
		}
		
		public System.Data.Linq.Table<student> students
		{
			get
			{
				return this.GetTable<student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.admin")]
	public partial class admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _adminId;
		
		private string _adminName;
		
		private System.Nullable<int> _adminNumber;
		
		private string _adminEmail;
		
		private string _adminPassword;
		
		private EntitySet<Course> _Courses;
		
		private EntitySet<student> _students;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnadminIdChanging(int value);
    partial void OnadminIdChanged();
    partial void OnadminNameChanging(string value);
    partial void OnadminNameChanged();
    partial void OnadminNumberChanging(System.Nullable<int> value);
    partial void OnadminNumberChanged();
    partial void OnadminEmailChanging(string value);
    partial void OnadminEmailChanged();
    partial void OnadminPasswordChanging(string value);
    partial void OnadminPasswordChanged();
    #endregion
		
		public admin()
		{
			this._Courses = new EntitySet<Course>(new Action<Course>(this.attach_Courses), new Action<Course>(this.detach_Courses));
			this._students = new EntitySet<student>(new Action<student>(this.attach_students), new Action<student>(this.detach_students));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adminId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int adminId
		{
			get
			{
				return this._adminId;
			}
			set
			{
				if ((this._adminId != value))
				{
					this.OnadminIdChanging(value);
					this.SendPropertyChanging();
					this._adminId = value;
					this.SendPropertyChanged("adminId");
					this.OnadminIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adminName", DbType="VarChar(30)")]
		public string adminName
		{
			get
			{
				return this._adminName;
			}
			set
			{
				if ((this._adminName != value))
				{
					this.OnadminNameChanging(value);
					this.SendPropertyChanging();
					this._adminName = value;
					this.SendPropertyChanged("adminName");
					this.OnadminNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adminNumber", DbType="Int")]
		public System.Nullable<int> adminNumber
		{
			get
			{
				return this._adminNumber;
			}
			set
			{
				if ((this._adminNumber != value))
				{
					this.OnadminNumberChanging(value);
					this.SendPropertyChanging();
					this._adminNumber = value;
					this.SendPropertyChanged("adminNumber");
					this.OnadminNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adminEmail", DbType="VarChar(50)")]
		public string adminEmail
		{
			get
			{
				return this._adminEmail;
			}
			set
			{
				if ((this._adminEmail != value))
				{
					this.OnadminEmailChanging(value);
					this.SendPropertyChanging();
					this._adminEmail = value;
					this.SendPropertyChanged("adminEmail");
					this.OnadminEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adminPassword", DbType="VarChar(50)")]
		public string adminPassword
		{
			get
			{
				return this._adminPassword;
			}
			set
			{
				if ((this._adminPassword != value))
				{
					this.OnadminPasswordChanging(value);
					this.SendPropertyChanging();
					this._adminPassword = value;
					this.SendPropertyChanged("adminPassword");
					this.OnadminPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="admin_Course", Storage="_Courses", ThisKey="adminId", OtherKey="adminId")]
		public EntitySet<Course> Courses
		{
			get
			{
				return this._Courses;
			}
			set
			{
				this._Courses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="admin_student", Storage="_students", ThisKey="adminId", OtherKey="adminId")]
		public EntitySet<student> students
		{
			get
			{
				return this._students;
			}
			set
			{
				this._students.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Courses(Course entity)
		{
			this.SendPropertyChanging();
			entity.admin = this;
		}
		
		private void detach_Courses(Course entity)
		{
			this.SendPropertyChanging();
			entity.admin = null;
		}
		
		private void attach_students(student entity)
		{
			this.SendPropertyChanging();
			entity.admin = this;
		}
		
		private void detach_students(student entity)
		{
			this.SendPropertyChanging();
			entity.admin = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Courses")]
	public partial class Course : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _courseId;
		
		private System.Nullable<int> _studentId;
		
		private string _courseLocation;
		
		private string _courseLanguage;
		
		private System.Nullable<int> _adminId;
		
		private EntitySet<score> _scores;
		
		private EntityRef<admin> _admin;
		
		private EntityRef<student> _student;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncourseIdChanging(int value);
    partial void OncourseIdChanged();
    partial void OnstudentIdChanging(System.Nullable<int> value);
    partial void OnstudentIdChanged();
    partial void OncourseLocationChanging(string value);
    partial void OncourseLocationChanged();
    partial void OncourseLanguageChanging(string value);
    partial void OncourseLanguageChanged();
    partial void OnadminIdChanging(System.Nullable<int> value);
    partial void OnadminIdChanged();
    #endregion
		
		public Course()
		{
			this._scores = new EntitySet<score>(new Action<score>(this.attach_scores), new Action<score>(this.detach_scores));
			this._admin = default(EntityRef<admin>);
			this._student = default(EntityRef<student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_courseId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int courseId
		{
			get
			{
				return this._courseId;
			}
			set
			{
				if ((this._courseId != value))
				{
					this.OncourseIdChanging(value);
					this.SendPropertyChanging();
					this._courseId = value;
					this.SendPropertyChanged("courseId");
					this.OncourseIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentId", DbType="Int")]
		public System.Nullable<int> studentId
		{
			get
			{
				return this._studentId;
			}
			set
			{
				if ((this._studentId != value))
				{
					if (this._student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnstudentIdChanging(value);
					this.SendPropertyChanging();
					this._studentId = value;
					this.SendPropertyChanged("studentId");
					this.OnstudentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_courseLocation", DbType="VarChar(50)")]
		public string courseLocation
		{
			get
			{
				return this._courseLocation;
			}
			set
			{
				if ((this._courseLocation != value))
				{
					this.OncourseLocationChanging(value);
					this.SendPropertyChanging();
					this._courseLocation = value;
					this.SendPropertyChanged("courseLocation");
					this.OncourseLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_courseLanguage", DbType="VarChar(50)")]
		public string courseLanguage
		{
			get
			{
				return this._courseLanguage;
			}
			set
			{
				if ((this._courseLanguage != value))
				{
					this.OncourseLanguageChanging(value);
					this.SendPropertyChanging();
					this._courseLanguage = value;
					this.SendPropertyChanged("courseLanguage");
					this.OncourseLanguageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adminId", DbType="Int")]
		public System.Nullable<int> adminId
		{
			get
			{
				return this._adminId;
			}
			set
			{
				if ((this._adminId != value))
				{
					if (this._admin.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnadminIdChanging(value);
					this.SendPropertyChanging();
					this._adminId = value;
					this.SendPropertyChanged("adminId");
					this.OnadminIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_score", Storage="_scores", ThisKey="courseId", OtherKey="courseId")]
		public EntitySet<score> scores
		{
			get
			{
				return this._scores;
			}
			set
			{
				this._scores.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="admin_Course", Storage="_admin", ThisKey="adminId", OtherKey="adminId", IsForeignKey=true)]
		public admin admin
		{
			get
			{
				return this._admin.Entity;
			}
			set
			{
				admin previousValue = this._admin.Entity;
				if (((previousValue != value) 
							|| (this._admin.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._admin.Entity = null;
						previousValue.Courses.Remove(this);
					}
					this._admin.Entity = value;
					if ((value != null))
					{
						value.Courses.Add(this);
						this._adminId = value.adminId;
					}
					else
					{
						this._adminId = default(Nullable<int>);
					}
					this.SendPropertyChanged("admin");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_Course", Storage="_student", ThisKey="studentId", OtherKey="studentId", IsForeignKey=true)]
		public student student
		{
			get
			{
				return this._student.Entity;
			}
			set
			{
				student previousValue = this._student.Entity;
				if (((previousValue != value) 
							|| (this._student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._student.Entity = null;
						previousValue.Courses.Remove(this);
					}
					this._student.Entity = value;
					if ((value != null))
					{
						value.Courses.Add(this);
						this._studentId = value.studentId;
					}
					else
					{
						this._studentId = default(Nullable<int>);
					}
					this.SendPropertyChanged("student");
				}
			}
		}

        public string courseName { get; internal set; }

        public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_scores(score entity)
		{
			this.SendPropertyChanging();
			entity.Course = this;
		}
		
		private void detach_scores(score entity)
		{
			this.SendPropertyChanging();
			entity.Course = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.score")]
	public partial class score : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _scoreId;
		
		private System.Nullable<double> _studentScore;
		
		private System.Nullable<int> _courseId;
		
		private System.Nullable<int> _studentId;
		
		private EntityRef<Course> _Course;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnscoreIdChanging(int value);
    partial void OnscoreIdChanged();
    partial void OnstudentScoreChanging(System.Nullable<double> value);
    partial void OnstudentScoreChanged();
    partial void OncourseIdChanging(System.Nullable<int> value);
    partial void OncourseIdChanged();
    partial void OnstudentIdChanging(System.Nullable<int> value);
    partial void OnstudentIdChanged();
    #endregion
		
		public score()
		{
			this._Course = default(EntityRef<Course>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_scoreId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int scoreId
		{
			get
			{
				return this._scoreId;
			}
			set
			{
				if ((this._scoreId != value))
				{
					this.OnscoreIdChanging(value);
					this.SendPropertyChanging();
					this._scoreId = value;
					this.SendPropertyChanged("scoreId");
					this.OnscoreIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentScore", DbType="Float")]
		public System.Nullable<double> studentScore
		{
			get
			{
				return this._studentScore;
			}
			set
			{
				if ((this._studentScore != value))
				{
					this.OnstudentScoreChanging(value);
					this.SendPropertyChanging();
					this._studentScore = value;
					this.SendPropertyChanged("studentScore");
					this.OnstudentScoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_courseId", DbType="Int")]
		public System.Nullable<int> courseId
		{
			get
			{
				return this._courseId;
			}
			set
			{
				if ((this._courseId != value))
				{
					if (this._Course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncourseIdChanging(value);
					this.SendPropertyChanging();
					this._courseId = value;
					this.SendPropertyChanged("courseId");
					this.OncourseIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentId", DbType="Int")]
		public System.Nullable<int> studentId
		{
			get
			{
				return this._studentId;
			}
			set
			{
				if ((this._studentId != value))
				{
					this.OnstudentIdChanging(value);
					this.SendPropertyChanging();
					this._studentId = value;
					this.SendPropertyChanged("studentId");
					this.OnstudentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_score", Storage="_Course", ThisKey="courseId", OtherKey="courseId", IsForeignKey=true)]
		public Course Course
		{
			get
			{
				return this._Course.Entity;
			}
			set
			{
				Course previousValue = this._Course.Entity;
				if (((previousValue != value) 
							|| (this._Course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Course.Entity = null;
						previousValue.scores.Remove(this);
					}
					this._Course.Entity = value;
					if ((value != null))
					{
						value.scores.Add(this);
						this._courseId = value.courseId;
					}
					else
					{
						this._courseId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Course");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.student")]
	public partial class student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _studentId;
		
		private string _studentFirstName;
		
		private string _studentLastName;
		
		private string _Gender;
		
		private System.Nullable<double> _gpa;
		
		private string _studentEmail;
		
		private string _studentPassword;
		
		private System.Nullable<int> _adminId;
		
		private EntitySet<Course> _Courses;
		
		private EntityRef<admin> _admin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnstudentIdChanging(int value);
    partial void OnstudentIdChanged();
    partial void OnstudentFirstNameChanging(string value);
    partial void OnstudentFirstNameChanged();
    partial void OnstudentLastNameChanging(string value);
    partial void OnstudentLastNameChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OngpaChanging(System.Nullable<double> value);
    partial void OngpaChanged();
    partial void OnstudentEmailChanging(string value);
    partial void OnstudentEmailChanged();
    partial void OnstudentPasswordChanging(string value);
    partial void OnstudentPasswordChanged();
    partial void OnadminIdChanging(System.Nullable<int> value);
    partial void OnadminIdChanged();
    #endregion
		
		public student()
		{
			this._Courses = new EntitySet<Course>(new Action<Course>(this.attach_Courses), new Action<Course>(this.detach_Courses));
			this._admin = default(EntityRef<admin>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int studentId
		{
			get
			{
				return this._studentId;
			}
			set
			{
				if ((this._studentId != value))
				{
					this.OnstudentIdChanging(value);
					this.SendPropertyChanging();
					this._studentId = value;
					this.SendPropertyChanged("studentId");
					this.OnstudentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentFirstName", DbType="VarChar(50)")]
		public string studentFirstName
		{
			get
			{
				return this._studentFirstName;
			}
			set
			{
				if ((this._studentFirstName != value))
				{
					this.OnstudentFirstNameChanging(value);
					this.SendPropertyChanging();
					this._studentFirstName = value;
					this.SendPropertyChanged("studentFirstName");
					this.OnstudentFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentLastName", DbType="VarChar(50)")]
		public string studentLastName
		{
			get
			{
				return this._studentLastName;
			}
			set
			{
				if ((this._studentLastName != value))
				{
					this.OnstudentLastNameChanging(value);
					this.SendPropertyChanging();
					this._studentLastName = value;
					this.SendPropertyChanged("studentLastName");
					this.OnstudentLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(1)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gpa", DbType="Float")]
		public System.Nullable<double> gpa
		{
			get
			{
				return this._gpa;
			}
			set
			{
				if ((this._gpa != value))
				{
					this.OngpaChanging(value);
					this.SendPropertyChanging();
					this._gpa = value;
					this.SendPropertyChanged("gpa");
					this.OngpaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentEmail", DbType="VarChar(50)")]
		public string studentEmail
		{
			get
			{
				return this._studentEmail;
			}
			set
			{
				if ((this._studentEmail != value))
				{
					this.OnstudentEmailChanging(value);
					this.SendPropertyChanging();
					this._studentEmail = value;
					this.SendPropertyChanged("studentEmail");
					this.OnstudentEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentPassword", DbType="VarChar(50)")]
		public string studentPassword
		{
			get
			{
				return this._studentPassword;
			}
			set
			{
				if ((this._studentPassword != value))
				{
					this.OnstudentPasswordChanging(value);
					this.SendPropertyChanging();
					this._studentPassword = value;
					this.SendPropertyChanged("studentPassword");
					this.OnstudentPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adminId", DbType="Int")]
		public System.Nullable<int> adminId
		{
			get
			{
				return this._adminId;
			}
			set
			{
				if ((this._adminId != value))
				{
					if (this._admin.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnadminIdChanging(value);
					this.SendPropertyChanging();
					this._adminId = value;
					this.SendPropertyChanged("adminId");
					this.OnadminIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_Course", Storage="_Courses", ThisKey="studentId", OtherKey="studentId")]
		public EntitySet<Course> Courses
		{
			get
			{
				return this._Courses;
			}
			set
			{
				this._Courses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="admin_student", Storage="_admin", ThisKey="adminId", OtherKey="adminId", IsForeignKey=true)]
		public admin admin
		{
			get
			{
				return this._admin.Entity;
			}
			set
			{
				admin previousValue = this._admin.Entity;
				if (((previousValue != value) 
							|| (this._admin.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._admin.Entity = null;
						previousValue.students.Remove(this);
					}
					this._admin.Entity = value;
					if ((value != null))
					{
						value.students.Add(this);
						this._adminId = value.adminId;
					}
					else
					{
						this._adminId = default(Nullable<int>);
					}
					this.SendPropertyChanged("admin");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Courses(Course entity)
		{
			this.SendPropertyChanging();
			entity.student = this;
		}
		
		private void detach_Courses(Course entity)
		{
			this.SendPropertyChanging();
			entity.student = null;
		}
	}
}
#pragma warning restore 1591
