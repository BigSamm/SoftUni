<?php

/* :task:create.html.twig */
class __TwigTemplate_c517018ef399f95051010888a14e5980d898b696f6e7aa2f05f5a4a39fa0338c extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":task:create.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_b132e7bc99649850e2cbda8aa4ef611e61cee9b80eb4171f75a57448984043fc = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_b132e7bc99649850e2cbda8aa4ef611e61cee9b80eb4171f75a57448984043fc->enter($__internal_b132e7bc99649850e2cbda8aa4ef611e61cee9b80eb4171f75a57448984043fc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":task:create.html.twig"));

        $__internal_52b221f73b34fb77f98765a00f501d2d7d1fed0493df05ac4a589a458f5a6442 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_52b221f73b34fb77f98765a00f501d2d7d1fed0493df05ac4a589a458f5a6442->enter($__internal_52b221f73b34fb77f98765a00f501d2d7d1fed0493df05ac4a589a458f5a6442_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":task:create.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_b132e7bc99649850e2cbda8aa4ef611e61cee9b80eb4171f75a57448984043fc->leave($__internal_b132e7bc99649850e2cbda8aa4ef611e61cee9b80eb4171f75a57448984043fc_prof);

        
        $__internal_52b221f73b34fb77f98765a00f501d2d7d1fed0493df05ac4a589a458f5a6442->leave($__internal_52b221f73b34fb77f98765a00f501d2d7d1fed0493df05ac4a589a458f5a6442_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_af94c19329e27a44d97240103f354f0503f34eadfab1e030be56e991c494e7f0 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_af94c19329e27a44d97240103f354f0503f34eadfab1e030be56e991c494e7f0->enter($__internal_af94c19329e27a44d97240103f354f0503f34eadfab1e030be56e991c494e7f0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_7d130fe0b48c4f4e3b10e56ade0a3a55e556a194bd11635e7358c666895a2ab6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7d130fe0b48c4f4e3b10e56ade0a3a55e556a194bd11635e7358c666895a2ab6->enter($__internal_7d130fe0b48c4f4e3b10e56ade0a3a55e556a194bd11635e7358c666895a2ab6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <div id=\"create-wrapper\">
        <section class=\"create\">
            <article>
                <form action=\"";
        // line 7
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("create");
        echo "\" method=\"POST\">
                    <div class=\"row\">
                        <label for=\"task\">Task:</label>
                        <input type=\"text\" id=\"task\" name=\"task[title]\">
                    </div>
                    <div class=\"row\">
                        <label for=\"comments\">Comments:</label>
                        <textarea id=\"comments\" name=\"task[comments]\"></textarea>
                    </div>

                    ";
        // line 17
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "

                    <button type=\"submit\">Create</button>
                </form>
            </article>
        </section>
    </div>
";
        
        $__internal_7d130fe0b48c4f4e3b10e56ade0a3a55e556a194bd11635e7358c666895a2ab6->leave($__internal_7d130fe0b48c4f4e3b10e56ade0a3a55e556a194bd11635e7358c666895a2ab6_prof);

        
        $__internal_af94c19329e27a44d97240103f354f0503f34eadfab1e030be56e991c494e7f0->leave($__internal_af94c19329e27a44d97240103f354f0503f34eadfab1e030be56e991c494e7f0_prof);

    }

    public function getTemplateName()
    {
        return ":task:create.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  67 => 17,  54 => 7,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
    <div id=\"create-wrapper\">
        <section class=\"create\">
            <article>
                <form action=\"{{ path('create') }}\" method=\"POST\">
                    <div class=\"row\">
                        <label for=\"task\">Task:</label>
                        <input type=\"text\" id=\"task\" name=\"task[title]\">
                    </div>
                    <div class=\"row\">
                        <label for=\"comments\">Comments:</label>
                        <textarea id=\"comments\" name=\"task[comments]\"></textarea>
                    </div>

                    {{ form_row(form._token) }}

                    <button type=\"submit\">Create</button>
                </form>
            </article>
        </section>
    </div>
{% endblock %}", ":task:create.html.twig", "D:\\PHP Skeleton\\app/Resources\\views/task/create.html.twig");
    }
}
