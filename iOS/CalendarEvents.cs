using System;
using EventKit;
using Foundation;
using SimpleChurchApp.Shared;
using UIKit;

namespace SimpleChurchApp.iOS
{
    public class CalendarEvents
    {
        public static void SaveCalendarEvent(ChurchEvent churchEvent)
        {
            EKEventStore store = new EKEventStore();
            EKCalendar calendar = null;

            store.RequestAccess (EKEntityType.Event, (bool granted, NSError e) => 
            {
                if (granted)
                {
                    calendar = store.DefaultCalendarForNewEvents;

                    if (calendar != null)
                    {
                        // Searches for every event in the next year
                        //                NSPredicate predicate = store.PredicateForEvents(NSDate.Now,DateTime.Now.AddDays(360),new EKCalendar[] {calendar});
                        //
                        //                store.EnumerateEvents(predicate, delegate(EKEvent currentEvent, ref bool stop)
                        //                    {
                        //                        // Perform your check for an event type
                        //                    });


                        // Add a new event
                        EKEvent newEvent = EKEvent.FromStore(store);
                        newEvent.Title = churchEvent.Title;
                        newEvent.Calendar = calendar;

                        newEvent.StartDate = (NSDate)DateTime.SpecifyKind(churchEvent.DateTime, DateTimeKind.Utc);
                        newEvent.EndDate = newEvent.StartDate.AddSeconds(36000);
                        newEvent.Availability = EKEventAvailability.Free;
                        NSError error;
                        store.SaveEvent(newEvent, EKSpan.ThisEvent, out error);
                    }
                }
                else
                {
                    new UIAlertView ( "Access Denied", 
                        "User Denied Access to Calendar Data", null,
                        "ok", null).Show ();
                }
            } );

            // Query the event

        }
    }
}

