import 'package:flutter/material.dart';
import 'package:responsive_sizer/responsive_sizer.dart';

class WelcomePageBackgroundWidget extends StatelessWidget {
  const WelcomePageBackgroundWidget({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Stack(
      children: [
        Image.asset(
          "lib/2-app/assets/images/backgroundWelcomePage.png",
          fit: BoxFit.fitHeight,
          height: 100.h,
          width: 100.w,
        ),
        Container(
          height: 100.h,
          width: 100.w,
          color: Color.fromRGBO(0, 0, 0, 0.4),
        )
      ],
    );
  }
}
