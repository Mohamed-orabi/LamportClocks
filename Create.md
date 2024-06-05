[User] --> |Web Application| --(query)--> |Cache Server| --(miss)--> |Web Service on Mainframe|
                                              ^          (hit)
                                              |
                                             (invalidate)
                                              |
                                   |Mainframe Trigger on Rate Update|
                                              |
                                   [IBM Mainframe with Rates Table]
