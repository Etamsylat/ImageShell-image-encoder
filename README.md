
# Image encoding using key

 Program uses given key to generate random numbers and switch pixels in image. It can also get image back to it's original state by using same key and decoding function.
 
 ## Key
 Key is made of pairs of numbers, first one being seed for rng and second one being number of encryptions (NOE). Huge numbers of encryption can slow down encoding and decoding.
 ### Examples of keys
 ***3;5*** - Will encrypt/decrypt with seed 3, NOE 5
 
 ***3;5;2;4*** - Will encrypt/decrypt with seed 3, NOE 5 and then with seed 2, NOE 4



