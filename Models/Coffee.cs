using System;
using System.ComponentModel.DataAnnotations;


namespace TheCaffinationStation.Models
{
	public class Coffee
	{
        public int Id { get; set; }

        public string Title { get; set; }

        public BeanVariety beanVariety { get; set; }
    }
}

