#include <QTextStream>

int main(void) {

   QTextStream out(stdout);

   QString a = "Eagle";

   out << a[0] << endl;
   out << a[4] << endl;

   out << a.at(0) << endl;


   return 0;
}
