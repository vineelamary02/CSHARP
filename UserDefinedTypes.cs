namespace OOPSProject
{
class Emp
{
public int? Eno;
public string? Name, Job;
public double? Salary;
public bool? Status;
}
class UserDefinedTypes
	{
		public Emp GetEmpDetails(int Eno)
			static void Main()
		{
			UserDefinedTypes udt = new UserDefinedTypes();
			Emp E = udt.GetEmpDetails(105);
			Console.ReadLine();
		}
	}
{
public Emp GetEmpDetails(int Eno)
{
			Emp obj = new Emp();
			obj.Eno = Eno;
			obj.Name = "James";
			obj.Salary = 90000.0;
			obj.Job = "clerk";
			obj.Status = true;
			return obj;

}
}
}