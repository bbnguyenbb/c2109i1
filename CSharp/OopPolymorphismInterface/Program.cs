using OopPolymorphismInterface;

//FileOne f = new();
//f.WriteBinaryFile();
//f.WriteTextFile();
//f.ReadFile();

//((IBinaryFile)f).ShowInfo();
//(f as IBinaryFile).ShowInfo();


//FileTwo f = new();
//f.WriteBinaryFile();
//f.WriteTextFile();
//(f as IBinaryFile).ReadFile();
//(f as ITextFile).ReadFile();

ITextFile itext = new FileOne();
itext.ReadFile();
itext = new FileTwo();
itext.ReadFile(); 