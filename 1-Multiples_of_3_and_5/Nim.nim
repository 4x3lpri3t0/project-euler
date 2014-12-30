var
  max = 1000
  sum = 0

for i in 1 .. <max:
  if i mod 3 == 0 or i mod 5 == 0:
    sum += i

echo(sum)