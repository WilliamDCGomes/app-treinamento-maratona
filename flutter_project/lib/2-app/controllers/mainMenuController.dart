import 'dart:ui';

import 'package:get/get.dart';

class MainMenuController extends GetxController {
  late String nameUser;
  late String nameInitials;
  late RxBool hasPicture;
  late RxString welcomePhrase;
  late final List<Color> colors;

  MainMenuController(){
    _startVariables();
    _getNameUser();
    _getNameInitials();
    _getWelcomePhrase();
  }

  _startVariables(){
    hasPicture = false.obs;
    colors = <Color>[];
    //colors.add(Color(0XFF5E2C8F));
    //colors.add(Color(0XFF8E2089));
    colors.add(Color(0XFF484592));
    colors.add(Color(0XFF619793));
  }

  _getNameUser(){
    nameUser = "Will";
  }

  _getNameInitials(){
    nameInitials = "WG";
  }

  _getWelcomePhrase(){
    int currentHour = DateTime.now().hour;
    if(currentHour >= 0 && currentHour < 12)
      welcomePhrase = "Bom dia!".obs;
    else if(currentHour >= 12 && currentHour < 18)
      welcomePhrase = "Boa tarde!".obs;
    else
      welcomePhrase = "Boa noite!".obs;
  }
}