using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    internal class Member3
    {
        private static double totalCost1 = 0;
        private static double totalCost2 = 0;
        private static double totalCost3 = 0;
        private static double totalCost4 = 0;
        private static double totalCost5 = 0;
        private static double totalCost6 = 0;
        private static double totalAmount = 0;

        public static void ComputeMenu1(Form form, TextBox food1, TextBox food2, TextBox food3)
        {
            int totalQuantity = 0;
            totalCost1 = 0;
            totalCost2 = 0;
            totalCost3 = 0;
            totalAmount = 0;

            int quantity1 = string.IsNullOrWhiteSpace(food1.Text) ? 0 : int.Parse(food1.Text);
            int quantity2 = string.IsNullOrWhiteSpace(food2.Text) ? 0 : int.Parse(food2.Text);
            int quantity3 = string.IsNullOrWhiteSpace(food3.Text) ? 0 : int.Parse(food3.Text);

            totalQuantity = quantity1 + quantity2 + quantity3;
            totalCost1 = 70 * quantity1;
            totalCost2 = 120 * quantity2;
            totalCost3 = 40 * quantity3;
            totalAmount = totalCost1 + totalCost2 + totalCost3;

            ApplyDiscountAndShowMessage(totalQuantity);
        }

        public static void ComputeMenu2(Form form, TextBox food4, TextBox food5, TextBox food6)
        {
            int totalQuantity = 0;
            totalCost4 = 0;
            totalCost5 = 0;
            totalCost6 = 0;
            totalAmount = 0;

            int quantity4 = string.IsNullOrWhiteSpace(food4.Text) ? 0 : int.Parse(food4.Text);
            int quantity5 = string.IsNullOrWhiteSpace(food5.Text) ? 0 : int.Parse(food5.Text);
            int quantity6 = string.IsNullOrWhiteSpace(food6.Text) ? 0 : int.Parse(food6.Text);

            totalQuantity = quantity4 + quantity5 + quantity6;
            totalCost4 = 143 * quantity4;
            totalCost5 = 59 * quantity5;
            totalCost6 = 133 * quantity6;
            totalAmount = totalCost4 + totalCost5 + totalCost6;

            ApplyDiscountAndShowMessage(totalQuantity);
        }

        private static void ApplyDiscountAndShowMessage(int totalQuantity)
        {
            if (totalQuantity > 5)
            {
                totalAmount *= 0.9;
                MessageBox.Show($"Total servings exceed 5, 10% discount applied to the total order.\nGrand Total: {totalAmount:C}\nThank you for your order!", "Thank you for dining with us! Here is the total cost of your order:");
            }
            else
            {
                MessageBox.Show($"Grand Total: {totalAmount:C}\nThank you for your order!", "Thank you for dining with us! Here is the total cost of your order:");
            }
        }
    }
}





