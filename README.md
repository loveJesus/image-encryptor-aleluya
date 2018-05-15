#image-encryptor-aleluya
Hallelujah, C# software to encrypt data into images (has a GUI, runs in Windows, and Linux/Osx with mono)


## Jesus Christ is the Lord

### Hallelujah - Why was this made?
First because i am interested in freedom of speech particularly in making the Bible available to countries where this 
has been oppressed. I am interested in people being able to communicate about Jesus with people in North Korea, or 
in places controlled by ISIS at this time. I am putting it on github because its an easy location for this to be
disected for errors, and made available.

Second i want to try making cross platform Desktop apps and was trying out mono for this, and apart from some minor GUI
hiccups it has worked well enough am thankful to Jesus for the tool. 

I also want to draw people who might be interested in the tool to know that Jesus is real.

### Hallelujah - What is this?
This is proof of concept software that takes a png image, and given a password will encrypt other data into the image.
The output image will have the data from that image encrypted into the original, it will normally be noticeable larger 
in filesize. 

### Hallelujah - How it works:
It will encrypt the data with aes, then it discards the least significant bit of every pixel and stores the data there.
The results should be invisible to the naked eye. Because of the way PNG works it will affect the file size rather
drastically. The rest of the PNG after data is done is padded with more random data. 

### Hallelujah - Notes:
The file encrypted must be under 1/8th the amount of bytes of the image W*H*3, 
I would not use this in highly sensitive areas. However it might be useful in regards to certain situations. 
Use at your own risk.
 
