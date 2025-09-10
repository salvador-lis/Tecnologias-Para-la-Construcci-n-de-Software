package com.example.nonsrp

class Employee(
    private val ID:Int,
    private val name : String,
    private var hoursWorked:Int,
    private var salary:Double
){
    fun calculatePay(){
        val ordinaryHours=regularHours()
        return (hoursWorked * ordinaryHours).toDouble()
    }

    fun reportHours(){
        val ordinaryHours = regularHours()
        return "Employee $name has worked $ordinaryHours ordinary hours"
    }

    fun saveEmployee(){
        print("Saving employee $name to database...")
    }

    private fun regularHours(): Int{
        return if(hoursWorked >35) 35 else hoursWorked
    }
}