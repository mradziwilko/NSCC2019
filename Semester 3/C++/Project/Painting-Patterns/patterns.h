#pragma once

#include <QWidget>

class Patterns : public QWidget {

  public:
    Patterns(QWidget *parent = 0);

  protected:
    void paintEvent(QPaintEvent *e);

  private:
    void doPainting();
};
