using MOMS.CustomerContext.Domain.Customers.Services;
using MOMS.CustomerContext.Domain.Customers;

namespace MOMS.CustomerContext.DomainService.Customers
{
    public class SendTextMessage : ISendTextMessage
    {
        public SendTextMessage()
        {

        }

        public void Send(Customer customer)
        {
            var gender= customer.Gender == 1 ? "خانم" : "آقای";
            string wellComeMessage = "با سلام خدمت " + gender + " " + customer.LastName + ".\n" + "پرونده شما در مطب دکتر دهری منش ثبت گردید.\n" + "شماره پرونده :" +  customer.FileNumber +"\n"+ "www.instagram.com/dr_Nazila_Dahrimanesh/";
            //var api = new KavenegarApi("426E624C4A3650772B37797A5238447450654B6C6775337373645A7474536E386C59315571454537754E6F3D");
            //api.Send("1000596446", customer.MobileNumber, wellComeMessage);
        }
    }
}
