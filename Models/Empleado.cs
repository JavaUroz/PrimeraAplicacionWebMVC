﻿namespace PrimeraAplicacionWebMVC.Models
{
	public class Empleado
	{
		public int Id { get; set; }
		public string? Nombre { get; set; }
		public string? Apellido { get; set; }
		public string? Direccion { get; set; }
		public string? Telefono { get; set; }
		public string? Email { get; set; }
		public string? Cuil { get; set; }
		public float Salario { get; set; }
	}
}
