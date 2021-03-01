#include <QTextStream>
#include <QFile>

int main(void) {

  QTextStream out(stdout);

  QFile file("Read.txt");

  if (!file.open(QIODevice::ReadOnly)) {

    qWarning("Cannot open file for reading");
    return 1;
  }

  QTextStream in(&file);

  while (!in.atEnd()) {

    QString line = in.readLine();
    out << line << endl;
  }

  file.close();
}
