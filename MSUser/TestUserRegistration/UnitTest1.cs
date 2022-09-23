namespace MSUser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FName()
        {
            string expected = "Priya";

            UC1FirstName Uc1 = new UC1FirstName("Priya");
            string actual = Uc1.ValidateFirstName();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }

        [TestMethod]
        public void LName()
        {
            string expected = "Dive";

            UC1FirstName Uc2 = new UC1FirstName("Dive");
            string actual = Uc2.ValidateFirstName();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }


        [TestMethod]
        public void Email()
        {
            string expected = "priya.dive@gmail.com";

            UC3Email UC3 = new UC3Email("priya.dive@gmail.com");
            string actual = UC3.ValidateEmail();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]    
        public void MobileNumber()
        {
            string expected = "+91 9975074123";

            UC4Mobile UC4 = new UC4Mobile("+91 9975074123");
            string actual = UC4.ValideMobileNumber();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void Rule1()
        {
            string expected = "priyadive";

            UC5Rule1 UC5 = new UC5Rule1("priyadive");
            string actual = UC5.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]

        public void Rule2()
        {
            string expected = "PriyankaDivekar";

            UC6Rule2 UC6 = new UC6Rule2("PriyankaDivekar");
            string actual = UC6.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void Rule3()
        {
            string expected = "Priyanka1103";

            UC7Rule3 UC7 = new UC7Rule3("Priyanka1103");
            string actual = UC7.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void TestPasswordRuleFour()
        {
            string expected = "PriyaDive@1103";

            UC8Rule4 Uc8 = new UC8Rule4("PriyaDive@1103");
            string actual = Uc8.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

    }
}