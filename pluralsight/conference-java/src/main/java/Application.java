import com.pluralsight.model.Speaker;
import com.pluralsight.service.SpeakerService;
import org.springframework.context.ApplicationContext;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class Application {
    public static void main(String[] args) {
        ApplicationContext appContext = new AnnotationConfigApplicationContext(AppConfig.class);
        SpeakerService service = appContext.getBean("speakerService", SpeakerService.class);
        Speaker speaker = service.findAll().get(0);

        System.out.printf("%s %s%n", speaker.getFirstName(), speaker.getLastName());
    }
}
