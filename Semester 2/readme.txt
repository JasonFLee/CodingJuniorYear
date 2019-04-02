DERIV.83P by Daniel J. Bishop, June 2000 (PUBLIC DOMAIN)

As you probably already know, you can use the TI-83's nDeriv() function to estimate derivatives.

f'(x)=nDeriv(f(x),X,X)
f"(x)=nDeriv(f'(x),X,X)

However, for some reason, you cannot use nested nDeriv statements to find the third derivative: This gives an error message.  To get around this limitation, I wrote this program, which estimates any derivative up to the seventh.  It could be very useful for finding Taylor polynomials.

How to use the program:

1. Run prgmDERIV.
2. Enter the expression for Y in terms of X.
3. Enter the value X at which you want to calculate the derivatives.
4. Enter a value for epsilon.  This number is used to calculate the derivatives.  Usually, you can get good results with .001 or .0001.

The calculator will display eight numbers:
Y=Y(X)
D1=dy/dx at X
D2=d²y/dx² at x
...
D7=seventh derivative at X

Note: For many functions, the higher-order derivatives will be incorrect because of the limited accuracy of the calculator.
Press enter to clear the screen and return to normal mode.

How it works:

I derived a formula to calculate the nth derivative of a function (see the formula.bmp file) and used it to find the formulas to estimate the derivatives.  Rather than actually finding the limit, the DERIV.83P estimates it using epsilon.

If you have any questions or comments, please e-mail me at danb2k@hotmail.com or danb_83@yahoo.com