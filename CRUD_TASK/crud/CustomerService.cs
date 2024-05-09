using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AggregratorContracts.AggregatorServices;

using Infra.Entities;
using ServiceContracts;
using Services;

namespace crud
{
    public class CustomerService(ICustomerAggregatorServices customerAggregateServices)
    {
        private readonly ICustomerAggregatorServices _customerAggregateServices = customerAggregateServices;


        public async Task<Customer?> GetCustomer(int? id)
        {
            try
            {
                var customer = await _customerAggregateServices.CustomerGetterServices.GetCustomer(id);
                return customer;
                 
                
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Argument error: {ex.Message}");
                throw;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Argument out of range error: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }


        }

        public async Task<List<Customer?>> GetCustomers()
        {
            try
            {
                var customers = await _customerAggregateServices.CustomerGetterServices.GetAll();
                return customers;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Argument error: {ex.Message}");
                throw;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Argument out of range error: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }

        }

        public async Task<bool> AddCustomer(Customer? customer)
        {
            try
            {
                var result = await _customerAggregateServices.CustomerAdderServices.AddCustomer(customer);

                return true;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Argument error: {ex.Message}");
                throw;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument error: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }

        public async Task<bool> UpdateCustomer(Customer? customer)
        {
            try
            {
                var result = await _customerAggregateServices.CustomerUpdaterServices.UpdateCustomer(customer);
                return true;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Argument error: {ex.Message}");
                throw;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument error: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }

        
    }



}
