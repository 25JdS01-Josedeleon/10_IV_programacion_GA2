Algoritmo calbasic
	definir opc Como Entero
	definir num1, num2 Como Entero
	Escribir "*************************"
	Escribir "menu de opciones"
	Escribir "**************************"
	Escribir "1- suma"
	Escribir "2- resta"
	Escribir "3- multiplicacion"
	Escribir "4- division"
	Escribir Sin Saltar "digite la opcion []"
	leer opc
	Escribir Sin Saltar"digite dos valores numericos"
	Leer num1
	leer num2
	
	Segun opc Hacer
		1:
			Escribir "la suma es: ", num1+num2
		2:
			Escribir "la resta es: ", num1-num2
		3:
			Escribir "la multiplicacion es: ", num1*num2
		4:
			Escribir "la Ddivision es: ", num1/num2
		De Otro Modo:
			Escribir "error al operar los numeros"
	Fin Segun
	
FinAlgoritmo
