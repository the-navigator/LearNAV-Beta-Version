
                      reader = comn.ExecuteReader();
                        while (reader.Read())
                        {

                       //     ListViewItem dt = new ListViewItem();
                            string search_var;
                           // int a;
                            //int b;
                     
                            rid = reader.GetValue(0).ToString(); 
                            rname = reader.GetValue(1).ToString();
                                     search_var = reader.GetValue(1).ToString();
                            rfilename = reader.GetValue(2).ToString();
                            rauthor = reader.GetValue(3).ToString();
                            rtags = reader.GetValue(5).ToString();

                           // return a + b;
                           


                          //  search_results.Items.Add(dt);
                          //  current_cnt.Text = search_results.Items.Count.ToString();