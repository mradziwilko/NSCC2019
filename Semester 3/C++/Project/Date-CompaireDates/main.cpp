#include <QTextStream>
#include <QDate>

int main(void) {

   QTextStream out(stdout);

   QDate dt1(2015, 4, 5);
   QDate dt2(2014, 4, 5);

   if (dt1 < dt2) {
       out << dt1.toString() << " comes before "
       << dt2.toString() << endl;
   } else {
       out << dt1.toString() << " comes after "
       << dt2.toString() << endl;
   }
}
