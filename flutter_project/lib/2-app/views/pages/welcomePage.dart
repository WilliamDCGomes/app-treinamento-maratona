import 'package:flutter/material.dart';
import 'package:flutter_project/2-app/views/viewsWidgets/backgroundsWidget/WelcomePageBackgroundWidget.dart';

class WelcomePage extends StatefulWidget {
  const WelcomePage({Key? key}) : super(key: key);

  @override
  _WelcomePageState createState() => _WelcomePageState();
}

class _WelcomePageState extends State<WelcomePage> {
  @override
  Widget build(BuildContext context) {
    return Stack(
      children: [
        WelcomePageBackgroundWidget(),
        Center(
          child: Column(
            children: [

            ],
          ),
        ),
      ],
    );
  }
}
