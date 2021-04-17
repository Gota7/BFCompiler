java -jar /usr/local/lib/antlr-4.9.2-complete.jar BF.g4 -o bin
javac bin/*.java
echo Running:
cd bin
java org.antlr.v4.gui.TestRig BF init -gui $1
cd ..
